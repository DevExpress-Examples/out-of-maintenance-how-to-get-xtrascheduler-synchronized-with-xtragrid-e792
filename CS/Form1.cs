using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Native;
using System.Collections;
using DevExpress.Data;
// ...

namespace SchedulerGridSync {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
		private CarsDBDataSet carsDBDataSet;
		private BindingSource carSchedulingBindingSource;
		private SchedulerGridSync.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter carSchedulingTableAdapter;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repImgPriority;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinDuration;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repImgSeverity;
		private DevExpress.XtraEditors.SplitterControl splitterControl2;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colSubject;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colLabel;
		private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
		private DevExpress.XtraGrid.Columns.GridColumn colLocation;
		private DevExpress.XtraGrid.Columns.GridColumn colAllDay;
		private System.ComponentModel.IContainer components;
		private Panel panel1;
		private Label label1;


		
		Hashtable appointmentRowHash = new Hashtable();

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
			this.carSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carsDBDataSet = new SchedulerGridSync.CarsDBDataSet();
			this.carSchedulingTableAdapter = new SchedulerGridSync.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter();
			this.repImgPriority = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repSpinDuration = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.repImgSeverity = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
			this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLabel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllDay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repImgPriority)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSpinDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repImgSeverity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
			this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 24);
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.Size = new System.Drawing.Size(808, 298);
			this.schedulerControl1.Start = new System.DateTime(2010, 7, 11, 0, 0, 0, 0);
			this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.Views.DayView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.MonthView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.schedulerControl1.Views.MonthView.WeekCount = 3;
			this.schedulerControl1.Views.TimelineView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.schedulerControl1.Views.WeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.schedulerControl1.Views.WorkWeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
			// 
			// schedulerDataStorage1
			// 
			this.schedulerDataStorage1.Appointments.DataSource = this.carSchedulingBindingSource;
			this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
			this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
			this.schedulerDataStorage1.Appointments.Mappings.End = "EndTime";
			this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
			this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
			this.schedulerDataStorage1.Appointments.Mappings.Start = "StartTime";
			this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
			this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
			this.schedulerDataStorage1.FilterAppointment += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerDataStorage1_FilterAppointment);
			this.schedulerDataStorage1.AppointmentCollectionCleared += new System.EventHandler(this.schedulerDataStorage1_AppointmentCollectionCleared);
			this.schedulerDataStorage1.AppointmentCollectionAutoReloading += new DevExpress.XtraScheduler.CancelListChangedEventHandler(this.schedulerDataStorage1_AppointmentCollectionAutoReloading);
			// 
			// carSchedulingBindingSource
			// 
			this.carSchedulingBindingSource.DataMember = "CarScheduling";
			this.carSchedulingBindingSource.DataSource = this.carsDBDataSet;
			// 
			// carsDBDataSet
			// 
			this.carsDBDataSet.DataSetName = "CarsDBDataSet";
			this.carsDBDataSet.Locale = new System.Globalization.CultureInfo("");
			this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// carSchedulingTableAdapter
			// 
			this.carSchedulingTableAdapter.ClearBeforeFill = true;
			// 
			// repImgPriority
			// 
			this.repImgPriority.AutoHeight = false;
			this.repImgPriority.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repImgPriority.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1)});
			this.repImgPriority.Name = "repImgPriority";
			// 
			// repSpinDuration
			// 
			this.repSpinDuration.AutoHeight = false;
			this.repSpinDuration.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repSpinDuration.IsFloatValue = false;
			this.repSpinDuration.Mask.EditMask = "N00";
			this.repSpinDuration.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.repSpinDuration.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.repSpinDuration.Name = "repSpinDuration";
			// 
			// repImgSeverity
			// 
			this.repImgSeverity.AutoHeight = false;
			this.repImgSeverity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repImgSeverity.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1)});
			this.repImgSeverity.Name = "repImgSeverity";
			// 
			// splitterControl2
			// 
			this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitterControl2.Location = new System.Drawing.Point(0, 322);
			this.splitterControl2.Name = "splitterControl2";
			this.splitterControl2.Size = new System.Drawing.Size(808, 6);
			this.splitterControl2.TabIndex = 8;
			this.splitterControl2.TabStop = false;
			// 
			// repositoryItemImageComboBox1
			// 
			this.repositoryItemImageComboBox1.AutoHeight = false;
			this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1)});
			this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
			// 
			// repositoryItemSpinEdit1
			// 
			this.repositoryItemSpinEdit1.AutoHeight = false;
			this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repositoryItemSpinEdit1.IsFloatValue = false;
			this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
			this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
			// 
			// repositoryItemImageComboBox2
			// 
			this.repositoryItemImageComboBox2.AutoHeight = false;
			this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1)});
			this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
			// 
			// repositoryItemImageComboBox3
			// 
			this.repositoryItemImageComboBox3.AutoHeight = false;
			this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1)});
			this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
			// 
			// repositoryItemSpinEdit2
			// 
			this.repositoryItemSpinEdit2.AutoHeight = false;
			this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repositoryItemSpinEdit2.IsFloatValue = false;
			this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
			this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.repositoryItemSpinEdit2.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
			// 
			// repositoryItemImageComboBox4
			// 
			this.repositoryItemImageComboBox4.AutoHeight = false;
			this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1)});
			this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.carSchedulingBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(0, 328);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(808, 233);
			this.gridControl1.TabIndex = 9;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colSubject,
            this.colDescription,
            this.colLabel,
            this.colStartTime,
            this.colEndTime,
            this.colLocation,
            this.colAllDay});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.MultiSelect = true;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 0;
			// 
			// colSubject
			// 
			this.colSubject.Caption = "Subject";
			this.colSubject.FieldName = "Subject";
			this.colSubject.Name = "colSubject";
			this.colSubject.Visible = true;
			this.colSubject.VisibleIndex = 1;
			// 
			// colDescription
			// 
			this.colDescription.Caption = "Description";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			// 
			// colLabel
			// 
			this.colLabel.Caption = "Label";
			this.colLabel.FieldName = "Label";
			this.colLabel.Name = "colLabel";
			this.colLabel.Visible = true;
			this.colLabel.VisibleIndex = 3;
			// 
			// colStartTime
			// 
			this.colStartTime.Caption = "StartTime";
			this.colStartTime.FieldName = "StartTime";
			this.colStartTime.Name = "colStartTime";
			this.colStartTime.Visible = true;
			this.colStartTime.VisibleIndex = 4;
			// 
			// colEndTime
			// 
			this.colEndTime.Caption = "EndTime";
			this.colEndTime.FieldName = "EndTime";
			this.colEndTime.Name = "colEndTime";
			this.colEndTime.Visible = true;
			this.colEndTime.VisibleIndex = 5;
			// 
			// colLocation
			// 
			this.colLocation.Caption = "Location";
			this.colLocation.FieldName = "Location";
			this.colLocation.Name = "colLocation";
			this.colLocation.Visible = true;
			this.colLocation.VisibleIndex = 6;
			// 
			// colAllDay
			// 
			this.colAllDay.Caption = "AllDay";
			this.colAllDay.FieldName = "AllDay";
			this.colAllDay.Name = "colAllDay";
			this.colAllDay.Visible = true;
			this.colAllDay.VisibleIndex = 7;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(808, 24);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(642, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Click to select grid rows and scheduler appointments. Use CTRL key to perform mul" +
				"ti-select. Use TAB to switch between appointments.";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 561);
			this.Controls.Add(this.schedulerControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitterControl2);
			this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to get XtraScheduler synchronized with XtraGrid";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repImgPriority)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSpinDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repImgSeverity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		
		protected Hashtable AppointmentRowHash { get { return appointmentRowHash; } }

		private void Form1_Load(object sender, EventArgs e) {
			this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);
			SubscribeSelectionEvents();
		}
		#region Selection events
		void SubscribeSelectionEvents() {
			this.schedulerControl1.SelectionChanged += new System.EventHandler(this.schedulerControl1_SelectionChanged);
			this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
		}

		void UnsubscribeSelectionEvents() {
			this.schedulerControl1.SelectionChanged -= new System.EventHandler(this.schedulerControl1_SelectionChanged);
			this.gridView1.SelectionChanged -= new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
		}
		#endregion

		#region Appointment-Row Relationship
		private void schedulerDataStorage1_FilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
			DataRowView rowView = (DataRowView)schedulerDataStorage1.GetObjectRow(e.Object);
			DataRow row = rowView.Row;

			if (!AppointmentRowHash.ContainsKey(row))
				AppointmentRowHash.Add(rowView.Row, e.Object);
		}

		private void schedulerDataStorage1_AppointmentCollectionCleared(object sender, EventArgs e) {
			AppointmentRowHash.Clear();
		}
		private void schedulerDataStorage1_AppointmentCollectionAutoReloading(object sender, CancelListChangedEventArgs e) {
			AppointmentRowHash.Clear();
		}
		protected Appointment FindAppointmentByRow(DataRow row) {
			return AppointmentRowHash[row] as Appointment;
		}

		#endregion

		private void schedulerControl1_SelectionChanged(object sender, EventArgs e) {
			UnsubscribeSelectionEvents();
			gridView1.BeginSelection();
			try {
				gridView1.ClearSelection();
				for (int i = 0; i < schedulerControl1.SelectedAppointments.Count; i++)
					UpdateGridSelection(schedulerControl1.SelectedAppointments[i]);

			} finally {
				gridView1.EndSelection();
				SubscribeSelectionEvents();
			}
		}
		private void UpdateGridSelection(Appointment apt) {
			DataRowView rowView = (DataRowView)apt.GetSourceObject(schedulerDataStorage1);
			int rowHandle = carsDBDataSet.CarScheduling.Rows.IndexOf(rowView.Row);
			gridView1.SelectRow(rowHandle);
			gridView1.MakeRowVisible(rowHandle, false);
		}
		private void gridView1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			UnsubscribeSelectionEvents();
			try {
				DataRow[] gridRows = GetGridSelectedRows();
				AppointmentBaseCollection aptsToSelect = PrepareAppointmentsToSelect(gridRows);

				UpdateSchedulerSelection(aptsToSelect);
			} finally {
				SubscribeSelectionEvents();
			}
		}
		DataRow[] GetGridSelectedRows() {
			int[] rowHandles = gridView1.GetSelectedRows();
			DataRow[] rows = new DataRow[rowHandles.Length];
			for (int i = 0; i < rowHandles.Length; i++)
				rows[i] = gridView1.GetDataRow(rowHandles[i]);
			return rows;
		}
		AppointmentBaseCollection PrepareAppointmentsToSelect(DataRow[] rows) {
			AppointmentBaseCollection appoitnments = new AppointmentBaseCollection();
			for (int i = 0; i < rows.Length; i++) {
				Appointment apt = FindAppointmentByRow(rows[i]);
				if (apt != null)
					appoitnments.Add(apt);
			}
			return appoitnments;
		}
		void UpdateSchedulerSelection(AppointmentBaseCollection appointments) {
			if (appointments.Count <= 0)
				return;

			SchedulerViewBase view = schedulerControl1.ActiveView;
			view.SelectAppointment(appointments[0]);

			schedulerControl1.BeginUpdate();
			try {
				for (int i = 1; i < appointments.Count; i++) 
					view.AddAppointmentSelection(appointments[i]);

			} finally {
				schedulerControl1.EndUpdate();
			}
		}

	}
}
