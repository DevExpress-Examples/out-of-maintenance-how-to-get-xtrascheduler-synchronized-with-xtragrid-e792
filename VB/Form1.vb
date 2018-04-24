Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Native
Imports System.Collections
Imports DevExpress.Data
' ...

Namespace SchedulerGridSync
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private carsDBDataSet_Renamed As CarsDBDataSet
        Private carSchedulingBindingSource As BindingSource
        Private carSchedulingTableAdapter As SchedulerGridSync.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
        Private repImgPriority As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repSpinDuration As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repImgSeverity As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private splitterControl2 As DevExpress.XtraEditors.SplitterControl
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private colLabel As DevExpress.XtraGrid.Columns.GridColumn
        Private colStartTime As DevExpress.XtraGrid.Columns.GridColumn
        Private colEndTime As DevExpress.XtraGrid.Columns.GridColumn
        Private colLocation As DevExpress.XtraGrid.Columns.GridColumn
        Private colAllDay As DevExpress.XtraGrid.Columns.GridColumn
        Private components As System.ComponentModel.IContainer
        Private panel1 As Panel
        Private label1 As Label




        Private appointmentRowHash_Renamed As New Hashtable()

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet_Renamed = New SchedulerGridSync.CarsDBDataSet()
            Me.carSchedulingTableAdapter = New SchedulerGridSync.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
            Me.repImgPriority = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repSpinDuration = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repImgSeverity = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.splitterControl2 = New DevExpress.XtraEditors.SplitterControl()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLabel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAllDay = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repImgPriority, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repSpinDuration, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repImgSeverity, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 24)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(808, 298)
            Me.schedulerControl1.Start = New Date(2005, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.MonthView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.Views.MonthView.WeekCount = 3
            Me.schedulerControl1.Views.TimelineView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.Views.WeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.Views.WorkWeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            ' 
            ' carSchedulingBindingSource
            ' 
            Me.carSchedulingBindingSource.DataMember = "CarScheduling"
            Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet_Renamed
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet_Renamed.Locale = New System.Globalization.CultureInfo("")
            Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carSchedulingTableAdapter
            ' 
            Me.carSchedulingTableAdapter.ClearBeforeFill = True
            ' 
            ' repImgPriority
            ' 
            Me.repImgPriority.AutoHeight = False
            Me.repImgPriority.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repImgPriority.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1) _
            })
            Me.repImgPriority.Name = "repImgPriority"
            ' 
            ' repSpinDuration
            ' 
            Me.repSpinDuration.AutoHeight = False
            Me.repSpinDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repSpinDuration.IsFloatValue = False
            Me.repSpinDuration.Mask.EditMask = "N00"
            Me.repSpinDuration.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.repSpinDuration.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.repSpinDuration.Name = "repSpinDuration"
            ' 
            ' repImgSeverity
            ' 
            Me.repImgSeverity.AutoHeight = False
            Me.repImgSeverity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repImgSeverity.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1) _
            })
            Me.repImgSeverity.Name = "repImgSeverity"
            ' 
            ' splitterControl2
            ' 
            Me.splitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.splitterControl2.Location = New System.Drawing.Point(0, 322)
            Me.splitterControl2.Name = "splitterControl2"
            Me.splitterControl2.Size = New System.Drawing.Size(808, 6)
            Me.splitterControl2.TabIndex = 8
            Me.splitterControl2.TabStop = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1) _
            })
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' repositoryItemImageComboBox2
            ' 
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1) _
            })
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            ' 
            ' repositoryItemImageComboBox3
            ' 
            Me.repositoryItemImageComboBox3.AutoHeight = False
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1) _
            })
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            ' 
            ' repositoryItemSpinEdit2
            ' 
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.repositoryItemSpinEdit2.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' repositoryItemImageComboBox4
            ' 
            Me.repositoryItemImageComboBox4.AutoHeight = False
            Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1), _
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1) _
            })
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.carSchedulingBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 328)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(808, 233)
            Me.gridControl1.TabIndex = 9
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colStatus, Me.colSubject, Me.colDescription, Me.colLabel, Me.colStartTime, Me.colEndTime, Me.colLocation, Me.colAllDay})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsSelection.MultiSelect = True
            ' 
            ' colStatus
            ' 
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 0
            ' 
            ' colSubject
            ' 
            Me.colSubject.Caption = "Subject"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 1
            ' 
            ' colDescription
            ' 
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
            ' 
            ' colLabel
            ' 
            Me.colLabel.Caption = "Label"
            Me.colLabel.FieldName = "Label"
            Me.colLabel.Name = "colLabel"
            Me.colLabel.Visible = True
            Me.colLabel.VisibleIndex = 3
            ' 
            ' colStartTime
            ' 
            Me.colStartTime.Caption = "StartTime"
            Me.colStartTime.FieldName = "StartTime"
            Me.colStartTime.Name = "colStartTime"
            Me.colStartTime.Visible = True
            Me.colStartTime.VisibleIndex = 4
            ' 
            ' colEndTime
            ' 
            Me.colEndTime.Caption = "EndTime"
            Me.colEndTime.FieldName = "EndTime"
            Me.colEndTime.Name = "colEndTime"
            Me.colEndTime.Visible = True
            Me.colEndTime.VisibleIndex = 5
            ' 
            ' colLocation
            ' 
            Me.colLocation.Caption = "Location"
            Me.colLocation.FieldName = "Location"
            Me.colLocation.Name = "colLocation"
            Me.colLocation.Visible = True
            Me.colLocation.VisibleIndex = 6
            ' 
            ' colAllDay
            ' 
            Me.colAllDay.Caption = "AllDay"
            Me.colAllDay.FieldName = "AllDay"
            Me.colAllDay.Name = "colAllDay"
            Me.colAllDay.Visible = True
            Me.colAllDay.VisibleIndex = 7
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(808, 24)
            Me.panel1.TabIndex = 10
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(4, 4)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(642, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Click to select grid rows and scheduler appointments. Use CTRL key to perform mul" & "ti-select. Use TAB to switch between appointments."
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(808, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.splitterControl2)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "SchedulerGridSync"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repImgPriority, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repSpinDuration, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repImgSeverity, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        #End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub


        Protected ReadOnly Property AppointmentRowHash() As Hashtable
            Get
                Return appointmentRowHash_Renamed
            End Get
        End Property

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet_Renamed.CarScheduling)
            SubscribeSelectionEvents()
        End Sub
        #Region "Selection events"
        Private Sub SubscribeSelectionEvents()
            AddHandler schedulerControl1.SelectionChanged, AddressOf schedulerControl1_SelectionChanged
            AddHandler gridView1.SelectionChanged, AddressOf gridView1_SelectionChanged
        End Sub

        Private Sub UnsubscribeSelectionEvents()
            RemoveHandler schedulerControl1.SelectionChanged, AddressOf schedulerControl1_SelectionChanged
            RemoveHandler gridView1.SelectionChanged, AddressOf gridView1_SelectionChanged
        End Sub
        #End Region

        #Region "Appointment-Row Relationship"
        Private Sub schedulerStorage1_FilterAppointment(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.FilterAppointment
            Dim rowView As DataRowView = CType(schedulerStorage1.GetObjectRow(e.Object), DataRowView)
            Dim row As DataRow = rowView.Row

            If Not AppointmentRowHash.ContainsKey(row) Then
                AppointmentRowHash.Add(rowView.Row, e.Object)
            End If
        End Sub

        Private Sub schedulerStorage1_AppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerStorage1.AppointmentCollectionCleared
            AppointmentRowHash.Clear()
        End Sub
        Private Sub schedulerStorage1_AppointmentCollectionAutoReloading(ByVal sender As Object, ByVal e As CancelListChangedEventArgs) Handles schedulerStorage1.AppointmentCollectionAutoReloading
            AppointmentRowHash.Clear()
        End Sub
        Protected Function FindAppointmentByRow(ByVal row As DataRow) As Appointment
            Return TryCast(AppointmentRowHash(row), Appointment)
        End Function

        #End Region

        Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeSelectionEvents()
            gridView1.BeginSelection()
            Try
                gridView1.ClearSelection()
                For i As Integer = 0 To schedulerControl1.SelectedAppointments.Count - 1
                    UpdateGridSelection(schedulerControl1.SelectedAppointments(i))
                Next i

            Finally
                gridView1.EndSelection()
                SubscribeSelectionEvents()
            End Try
        End Sub
        Private Sub UpdateGridSelection(ByVal apt As Appointment)
            Dim rowView As DataRowView = CType(apt.GetSourceObject(schedulerStorage1), DataRowView)
            Dim rowHandle As Integer = carsDBDataSet_Renamed.CarScheduling.Rows.IndexOf(rowView.Row)
            gridView1.SelectRow(rowHandle)
            gridView1.MakeRowVisible(rowHandle, False)
        End Sub
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            UnsubscribeSelectionEvents()
            Try
                Dim gridRows() As DataRow = GetGridSelectedRows()
                Dim aptsToSelect As AppointmentBaseCollection = PrepareAppointmentsToSelect(gridRows)

                UpdateSchedulerSelection(aptsToSelect)
            Finally
                SubscribeSelectionEvents()
            End Try
        End Sub
        Private Function GetGridSelectedRows() As DataRow()
            Dim rowHandles() As Integer = gridView1.GetSelectedRows()
            Dim rows(rowHandles.Length - 1) As DataRow
            For i As Integer = 0 To rowHandles.Length - 1
                rows(i) = gridView1.GetDataRow(rowHandles(i))
            Next i
            Return rows
        End Function
        Private Function PrepareAppointmentsToSelect(ByVal rows() As DataRow) As AppointmentBaseCollection
            Dim appoitnments As New AppointmentBaseCollection()
            For i As Integer = 0 To rows.Length - 1
                Dim apt As Appointment = FindAppointmentByRow(rows(i))
                If apt IsNot Nothing Then
                    appoitnments.Add(apt)
                End If
            Next i
            Return appoitnments
        End Function
        Private Sub UpdateSchedulerSelection(ByVal appointments As AppointmentBaseCollection)
            If appointments.Count <= 0 Then
                Return
            End If

            Dim view As SchedulerViewBase = schedulerControl1.ActiveView
            view.SelectAppointment(appointments(0))

            schedulerControl1.BeginUpdate()
            Try
                For i As Integer = 1 To appointments.Count - 1
                    view.AddAppointmentSelection(appointments(i))
                Next i

            Finally
                schedulerControl1.EndUpdate()
            End Try
        End Sub

    End Class
End Namespace
