<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLastChecked = New System.Windows.Forms.Label()
        Me.tCheckQueue = New System.Windows.Forms.Timer(Me.components)
        Me.lblIrrigationQueue = New System.Windows.Forms.Label()
        Me.lblInsteonQueue = New System.Windows.Forms.Label()
        Me.lblBlindsQueue = New System.Windows.Forms.Label()
        Me.lblTempQueue = New System.Windows.Forms.Label()
        Me.Event_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDQueueMonitor.WatchdogDataSet()
        Me.Blinds_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blinds_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insteon_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insteon_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Irrigation_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Irrigation_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Temp_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temp_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_HistoryTableAdapter = New WDQueueMonitor.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter()
        Me.TableAdapterManager = New WDQueueMonitor.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Blinds_ControlTableAdapter = New WDQueueMonitor.WatchdogDataSetTableAdapters.Blinds_ControlTableAdapter()
        Me.Insteon_ControlTableAdapter = New WDQueueMonitor.WatchdogDataSetTableAdapters.Insteon_ControlTableAdapter()
        Me.Irrigation_ControlTableAdapter = New WDQueueMonitor.WatchdogDataSetTableAdapters.Irrigation_ControlTableAdapter()
        Me.Temp_ControlTableAdapter = New WDQueueMonitor.WatchdogDataSetTableAdapters.Temp_ControlTableAdapter()
        Me.tSendAlert = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLastAlert = New System.Windows.Forms.Label()
        Me.lblTempFlag = New System.Windows.Forms.Label()
        Me.lblBlindsFlag = New System.Windows.Forms.Label()
        Me.lblInsteonFlag = New System.Windows.Forms.Label()
        Me.lblIrrigationFlag = New System.Windows.Forms.Label()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insteon_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insteon_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Irrigation_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Irrigation_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Irrigation Queue:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insteon Queue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blinds Queue:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Temperature Queue:"
        '
        'btnOn
        '
        Me.btnOn.Enabled = False
        Me.btnOn.Location = New System.Drawing.Point(9, 91)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(82, 23)
        Me.btnOn.TabIndex = 4
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(97, 91)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(82, 23)
        Me.btnOff.TabIndex = 5
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Last Checked:"
        '
        'lblLastChecked
        '
        Me.lblLastChecked.AutoSize = True
        Me.lblLastChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChecked.Location = New System.Drawing.Point(78, 123)
        Me.lblLastChecked.Name = "lblLastChecked"
        Me.lblLastChecked.Size = New System.Drawing.Size(89, 12)
        Me.lblLastChecked.TabIndex = 7
        Me.lblLastChecked.Text = "12/31/2000 12:00:00"
        '
        'tCheckQueue
        '
        Me.tCheckQueue.Interval = 500
        '
        'lblIrrigationQueue
        '
        Me.lblIrrigationQueue.AutoSize = True
        Me.lblIrrigationQueue.Location = New System.Drawing.Point(125, 7)
        Me.lblIrrigationQueue.Name = "lblIrrigationQueue"
        Me.lblIrrigationQueue.Size = New System.Drawing.Size(13, 13)
        Me.lblIrrigationQueue.TabIndex = 8
        Me.lblIrrigationQueue.Text = "0"
        '
        'lblInsteonQueue
        '
        Me.lblInsteonQueue.AutoSize = True
        Me.lblInsteonQueue.Location = New System.Drawing.Point(125, 26)
        Me.lblInsteonQueue.Name = "lblInsteonQueue"
        Me.lblInsteonQueue.Size = New System.Drawing.Size(13, 13)
        Me.lblInsteonQueue.TabIndex = 9
        Me.lblInsteonQueue.Text = "0"
        '
        'lblBlindsQueue
        '
        Me.lblBlindsQueue.AutoSize = True
        Me.lblBlindsQueue.Location = New System.Drawing.Point(125, 46)
        Me.lblBlindsQueue.Name = "lblBlindsQueue"
        Me.lblBlindsQueue.Size = New System.Drawing.Size(13, 13)
        Me.lblBlindsQueue.TabIndex = 10
        Me.lblBlindsQueue.Text = "0"
        '
        'lblTempQueue
        '
        Me.lblTempQueue.AutoSize = True
        Me.lblTempQueue.Location = New System.Drawing.Point(125, 66)
        Me.lblTempQueue.Name = "lblTempQueue"
        Me.lblTempQueue.Size = New System.Drawing.Size(13, 13)
        Me.lblTempQueue.TabIndex = 11
        Me.lblTempQueue.Text = "0"
        '
        'Event_HistoryDataGridView
        '
        Me.Event_HistoryDataGridView.AllowUserToAddRows = False
        Me.Event_HistoryDataGridView.AllowUserToDeleteRows = False
        Me.Event_HistoryDataGridView.AutoGenerateColumns = False
        Me.Event_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Event_HistoryDataGridView.DataSource = Me.Event_HistoryBindingSource
        Me.Event_HistoryDataGridView.Enabled = False
        Me.Event_HistoryDataGridView.Location = New System.Drawing.Point(162, 7)
        Me.Event_HistoryDataGridView.Name = "Event_HistoryDataGridView"
        Me.Event_HistoryDataGridView.ReadOnly = True
        Me.Event_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_HistoryDataGridView.TabIndex = 13
        Me.Event_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Event_HistoryBindingSource
        '
        Me.Event_HistoryBindingSource.DataMember = "Event_History"
        Me.Event_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Blinds_ControlDataGridView
        '
        Me.Blinds_ControlDataGridView.AllowUserToAddRows = False
        Me.Blinds_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Blinds_ControlDataGridView.AutoGenerateColumns = False
        Me.Blinds_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Blinds_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Blinds_ControlDataGridView.DataSource = Me.Blinds_ControlBindingSource
        Me.Blinds_ControlDataGridView.Enabled = False
        Me.Blinds_ControlDataGridView.Location = New System.Drawing.Point(162, 23)
        Me.Blinds_ControlDataGridView.Name = "Blinds_ControlDataGridView"
        Me.Blinds_ControlDataGridView.ReadOnly = True
        Me.Blinds_ControlDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Blinds_ControlDataGridView.TabIndex = 13
        Me.Blinds_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Blind_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Blind_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Blind_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Blind_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Blind_Current_State"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Blind_Current_State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Blind_Request_State"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Blind_Request_State"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Blinds_ControlBindingSource
        '
        Me.Blinds_ControlBindingSource.DataMember = "Blinds_Control"
        Me.Blinds_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Insteon_ControlDataGridView
        '
        Me.Insteon_ControlDataGridView.AllowUserToAddRows = False
        Me.Insteon_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Insteon_ControlDataGridView.AutoGenerateColumns = False
        Me.Insteon_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Insteon_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Insteon_ControlDataGridView.DataSource = Me.Insteon_ControlBindingSource
        Me.Insteon_ControlDataGridView.Enabled = False
        Me.Insteon_ControlDataGridView.Location = New System.Drawing.Point(162, 39)
        Me.Insteon_ControlDataGridView.Name = "Insteon_ControlDataGridView"
        Me.Insteon_ControlDataGridView.ReadOnly = True
        Me.Insteon_ControlDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Insteon_ControlDataGridView.TabIndex = 14
        Me.Insteon_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Device_Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Device_Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Device_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Device_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Device_Current_State"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Device_Current_State"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Device_Request_State"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Device_Request_State"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Insteon_ControlBindingSource
        '
        Me.Insteon_ControlBindingSource.DataMember = "Insteon_Control"
        Me.Insteon_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Irrigation_ControlDataGridView
        '
        Me.Irrigation_ControlDataGridView.AllowUserToAddRows = False
        Me.Irrigation_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Irrigation_ControlDataGridView.AutoGenerateColumns = False
        Me.Irrigation_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Irrigation_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Irrigation_ControlDataGridView.DataSource = Me.Irrigation_ControlBindingSource
        Me.Irrigation_ControlDataGridView.Enabled = False
        Me.Irrigation_ControlDataGridView.Location = New System.Drawing.Point(162, 57)
        Me.Irrigation_ControlDataGridView.Name = "Irrigation_ControlDataGridView"
        Me.Irrigation_ControlDataGridView.ReadOnly = True
        Me.Irrigation_ControlDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Irrigation_ControlDataGridView.TabIndex = 15
        Me.Irrigation_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Zone_ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Zone_ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Zone_Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Zone_Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Zone_Current_State"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Zone_Current_State"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Zone_Request_State"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Zone_Request_State"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'Irrigation_ControlBindingSource
        '
        Me.Irrigation_ControlBindingSource.DataMember = "Irrigation_Control"
        Me.Irrigation_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Temp_ControlDataGridView
        '
        Me.Temp_ControlDataGridView.AllowUserToAddRows = False
        Me.Temp_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Temp_ControlDataGridView.AutoGenerateColumns = False
        Me.Temp_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Temp_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Temp_ControlDataGridView.DataSource = Me.Temp_ControlBindingSource
        Me.Temp_ControlDataGridView.Enabled = False
        Me.Temp_ControlDataGridView.Location = New System.Drawing.Point(162, 73)
        Me.Temp_ControlDataGridView.Name = "Temp_ControlDataGridView"
        Me.Temp_ControlDataGridView.ReadOnly = True
        Me.Temp_ControlDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Temp_ControlDataGridView.TabIndex = 16
        Me.Temp_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Temp_Mode"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Temp_Mode"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Temp_Direction"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Temp_Direction"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Temp_Degrees"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Temp_Degrees"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'Temp_ControlBindingSource
        '
        Me.Temp_ControlBindingSource.DataMember = "Temp_Control"
        Me.Temp_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Event_HistoryTableAdapter
        '
        Me.Event_HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blinds_ControlTableAdapter = Me.Blinds_ControlTableAdapter
        Me.TableAdapterManager.Event_HistoryTableAdapter = Me.Event_HistoryTableAdapter
        Me.TableAdapterManager.Insteon_ControlTableAdapter = Me.Insteon_ControlTableAdapter
        Me.TableAdapterManager.Irrigation_ControlTableAdapter = Me.Irrigation_ControlTableAdapter
        Me.TableAdapterManager.Temp_ControlTableAdapter = Me.Temp_ControlTableAdapter
        Me.TableAdapterManager.UpdateOrder = WDQueueMonitor.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Blinds_ControlTableAdapter
        '
        Me.Blinds_ControlTableAdapter.ClearBeforeFill = True
        '
        'Insteon_ControlTableAdapter
        '
        Me.Insteon_ControlTableAdapter.ClearBeforeFill = True
        '
        'Irrigation_ControlTableAdapter
        '
        Me.Irrigation_ControlTableAdapter.ClearBeforeFill = True
        '
        'Temp_ControlTableAdapter
        '
        Me.Temp_ControlTableAdapter.ClearBeforeFill = True
        '
        'tSendAlert
        '
        Me.tSendAlert.Interval = 1000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Last Alert:"
        '
        'lblLastAlert
        '
        Me.lblLastAlert.AutoSize = True
        Me.lblLastAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAlert.Location = New System.Drawing.Point(78, 137)
        Me.lblLastAlert.Name = "lblLastAlert"
        Me.lblLastAlert.Size = New System.Drawing.Size(89, 12)
        Me.lblLastAlert.TabIndex = 18
        Me.lblLastAlert.Text = "12/31/2000 12:00:00"
        '
        'lblTempFlag
        '
        Me.lblTempFlag.AutoSize = True
        Me.lblTempFlag.Location = New System.Drawing.Point(144, 66)
        Me.lblTempFlag.Name = "lblTempFlag"
        Me.lblTempFlag.Size = New System.Drawing.Size(10, 13)
        Me.lblTempFlag.TabIndex = 22
        Me.lblTempFlag.Text = "-"
        '
        'lblBlindsFlag
        '
        Me.lblBlindsFlag.AutoSize = True
        Me.lblBlindsFlag.Location = New System.Drawing.Point(144, 46)
        Me.lblBlindsFlag.Name = "lblBlindsFlag"
        Me.lblBlindsFlag.Size = New System.Drawing.Size(10, 13)
        Me.lblBlindsFlag.TabIndex = 21
        Me.lblBlindsFlag.Text = "-"
        '
        'lblInsteonFlag
        '
        Me.lblInsteonFlag.AutoSize = True
        Me.lblInsteonFlag.Location = New System.Drawing.Point(144, 26)
        Me.lblInsteonFlag.Name = "lblInsteonFlag"
        Me.lblInsteonFlag.Size = New System.Drawing.Size(10, 13)
        Me.lblInsteonFlag.TabIndex = 20
        Me.lblInsteonFlag.Text = "-"
        '
        'lblIrrigationFlag
        '
        Me.lblIrrigationFlag.AutoSize = True
        Me.lblIrrigationFlag.Location = New System.Drawing.Point(144, 7)
        Me.lblIrrigationFlag.Name = "lblIrrigationFlag"
        Me.lblIrrigationFlag.Size = New System.Drawing.Size(10, 13)
        Me.lblIrrigationFlag.TabIndex = 19
        Me.lblIrrigationFlag.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 154)
        Me.Controls.Add(Me.lblTempFlag)
        Me.Controls.Add(Me.lblBlindsFlag)
        Me.Controls.Add(Me.lblInsteonFlag)
        Me.Controls.Add(Me.lblIrrigationFlag)
        Me.Controls.Add(Me.lblLastAlert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Temp_ControlDataGridView)
        Me.Controls.Add(Me.Irrigation_ControlDataGridView)
        Me.Controls.Add(Me.Insteon_ControlDataGridView)
        Me.Controls.Add(Me.Blinds_ControlDataGridView)
        Me.Controls.Add(Me.Event_HistoryDataGridView)
        Me.Controls.Add(Me.lblTempQueue)
        Me.Controls.Add(Me.lblBlindsQueue)
        Me.Controls.Add(Me.lblInsteonQueue)
        Me.Controls.Add(Me.lblIrrigationQueue)
        Me.Controls.Add(Me.lblLastChecked)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "WDQueueMonitor"
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insteon_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insteon_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Irrigation_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Irrigation_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblLastChecked As System.Windows.Forms.Label
    Friend WithEvents tCheckQueue As System.Windows.Forms.Timer
    Friend WithEvents lblIrrigationQueue As System.Windows.Forms.Label
    Friend WithEvents lblInsteonQueue As System.Windows.Forms.Label
    Friend WithEvents lblBlindsQueue As System.Windows.Forms.Label
    Friend WithEvents lblTempQueue As System.Windows.Forms.Label
    Friend WithEvents WatchdogDataSet As WDQueueMonitor.WatchdogDataSet
    Friend WithEvents Event_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_HistoryTableAdapter As WDQueueMonitor.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Friend WithEvents TableAdapterManager As WDQueueMonitor.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Blinds_ControlTableAdapter As WDQueueMonitor.WatchdogDataSetTableAdapters.Blinds_ControlTableAdapter
    Friend WithEvents Event_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Blinds_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Insteon_ControlTableAdapter As WDQueueMonitor.WatchdogDataSetTableAdapters.Insteon_ControlTableAdapter
    Friend WithEvents Blinds_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insteon_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Irrigation_ControlTableAdapter As WDQueueMonitor.WatchdogDataSetTableAdapters.Irrigation_ControlTableAdapter
    Friend WithEvents Insteon_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Irrigation_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_ControlTableAdapter As WDQueueMonitor.WatchdogDataSetTableAdapters.Temp_ControlTableAdapter
    Friend WithEvents Irrigation_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Temp_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tSendAlert As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLastAlert As System.Windows.Forms.Label
    Friend WithEvents lblTempFlag As System.Windows.Forms.Label
    Friend WithEvents lblBlindsFlag As System.Windows.Forms.Label
    Friend WithEvents lblInsteonFlag As System.Windows.Forms.Label
    Friend WithEvents lblIrrigationFlag As System.Windows.Forms.Label

End Class
