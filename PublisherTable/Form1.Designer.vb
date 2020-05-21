<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublisherTable
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPublishers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSelectPublisher = New System.Windows.Forms.Label()
        Me.gbPublisherInformation = New System.Windows.Forms.GroupBox()
        Me.Company_NameLabel1 = New System.Windows.Forms.Label()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New PublisherTable.ContactsDataSet()
        Me.FaxLabel1 = New System.Windows.Forms.Label()
        Me.TelephoneLabel1 = New System.Windows.Forms.Label()
        Me.ZipLabel1 = New System.Windows.Forms.Label()
        Me.StateLabel1 = New System.Windows.Forms.Label()
        Me.CityLabel1 = New System.Windows.Forms.Label()
        Me.AddressLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.PubIDLabel1 = New System.Windows.Forms.Label()
        Me.lblFaxNumber = New System.Windows.Forms.Label()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.PublishersTableAdapter = New PublisherTable.ContactsDataSetTableAdapters.PublishersTableAdapter()
        Me.TableAdapterManager = New PublisherTable.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbPublisherInformation.SuspendLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.mnuPublishers, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuReset
        '
        Me.mnuReset.Enabled = False
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(180, 22)
        Me.mnuReset.Text = "&Reset"
        Me.mnuReset.ToolTipText = "Deselect Publisher"
        '
        'mnuPublishers
        '
        Me.mnuPublishers.Name = "mnuPublishers"
        Me.mnuPublishers.Size = New System.Drawing.Size(180, 22)
        Me.mnuPublishers.Text = "&View all Publishers"
        Me.mnuPublishers.ToolTipText = "View a list of Publishers"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "&Exit"
        Me.mnuExit.ToolTipText = "Exit the program"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "&About"
        Me.mnuAbout.ToolTipText = "About the Program"
        '
        'lblSelectPublisher
        '
        Me.lblSelectPublisher.AutoSize = True
        Me.lblSelectPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectPublisher.Location = New System.Drawing.Point(12, 36)
        Me.lblSelectPublisher.Name = "lblSelectPublisher"
        Me.lblSelectPublisher.Size = New System.Drawing.Size(163, 17)
        Me.lblSelectPublisher.TabIndex = 1
        Me.lblSelectPublisher.Text = "Select Publisher to View:"
        '
        'gbPublisherInformation
        '
        Me.gbPublisherInformation.Controls.Add(Me.Company_NameLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.FaxLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.TelephoneLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.ZipLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.StateLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.CityLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.AddressLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.NameLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.PubIDLabel1)
        Me.gbPublisherInformation.Controls.Add(Me.lblFaxNumber)
        Me.gbPublisherInformation.Controls.Add(Me.lblTelephoneNumber)
        Me.gbPublisherInformation.Controls.Add(Me.lblZipCode)
        Me.gbPublisherInformation.Controls.Add(Me.lblState)
        Me.gbPublisherInformation.Controls.Add(Me.lblCity)
        Me.gbPublisherInformation.Controls.Add(Me.lblAddress)
        Me.gbPublisherInformation.Controls.Add(Me.lblCompanyName)
        Me.gbPublisherInformation.Controls.Add(Me.lblName)
        Me.gbPublisherInformation.Controls.Add(Me.lblID)
        Me.gbPublisherInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPublisherInformation.Location = New System.Drawing.Point(12, 72)
        Me.gbPublisherInformation.Name = "gbPublisherInformation"
        Me.gbPublisherInformation.Size = New System.Drawing.Size(628, 286)
        Me.gbPublisherInformation.TabIndex = 3
        Me.gbPublisherInformation.TabStop = False
        Me.gbPublisherInformation.Text = "Publisher Information"
        '
        'Company_NameLabel1
        '
        Me.Company_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Company Name", True))
        Me.Company_NameLabel1.Location = New System.Drawing.Point(168, 81)
        Me.Company_NameLabel1.Name = "Company_NameLabel1"
        Me.Company_NameLabel1.Size = New System.Drawing.Size(448, 23)
        Me.Company_NameLabel1.TabIndex = 28
        Me.Company_NameLabel1.Text = "Label1"
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FaxLabel1
        '
        Me.FaxLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Fax", True))
        Me.FaxLabel1.Location = New System.Drawing.Point(168, 243)
        Me.FaxLabel1.Name = "FaxLabel1"
        Me.FaxLabel1.Size = New System.Drawing.Size(448, 23)
        Me.FaxLabel1.TabIndex = 27
        Me.FaxLabel1.Text = "Label1"
        '
        'TelephoneLabel1
        '
        Me.TelephoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Telephone", True))
        Me.TelephoneLabel1.Location = New System.Drawing.Point(168, 216)
        Me.TelephoneLabel1.Name = "TelephoneLabel1"
        Me.TelephoneLabel1.Size = New System.Drawing.Size(448, 23)
        Me.TelephoneLabel1.TabIndex = 26
        Me.TelephoneLabel1.Text = "Label1"
        '
        'ZipLabel1
        '
        Me.ZipLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Zip", True))
        Me.ZipLabel1.Location = New System.Drawing.Point(168, 189)
        Me.ZipLabel1.Name = "ZipLabel1"
        Me.ZipLabel1.Size = New System.Drawing.Size(448, 23)
        Me.ZipLabel1.TabIndex = 25
        Me.ZipLabel1.Text = "Label1"
        '
        'StateLabel1
        '
        Me.StateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "State", True))
        Me.StateLabel1.Location = New System.Drawing.Point(168, 162)
        Me.StateLabel1.Name = "StateLabel1"
        Me.StateLabel1.Size = New System.Drawing.Size(448, 23)
        Me.StateLabel1.TabIndex = 24
        Me.StateLabel1.Text = "Label1"
        '
        'CityLabel1
        '
        Me.CityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "City", True))
        Me.CityLabel1.Location = New System.Drawing.Point(168, 135)
        Me.CityLabel1.Name = "CityLabel1"
        Me.CityLabel1.Size = New System.Drawing.Size(448, 23)
        Me.CityLabel1.TabIndex = 23
        Me.CityLabel1.Text = "Label1"
        '
        'AddressLabel1
        '
        Me.AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Address", True))
        Me.AddressLabel1.Location = New System.Drawing.Point(168, 108)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(448, 23)
        Me.AddressLabel1.TabIndex = 22
        Me.AddressLabel1.Text = "Label1"
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(168, 54)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(448, 23)
        Me.NameLabel1.TabIndex = 20
        Me.NameLabel1.Text = "Label1"
        '
        'PubIDLabel1
        '
        Me.PubIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "PubID", True))
        Me.PubIDLabel1.Location = New System.Drawing.Point(168, 27)
        Me.PubIDLabel1.Name = "PubIDLabel1"
        Me.PubIDLabel1.Size = New System.Drawing.Size(448, 23)
        Me.PubIDLabel1.TabIndex = 19
        Me.PubIDLabel1.Text = "Label1"
        '
        'lblFaxNumber
        '
        Me.lblFaxNumber.AutoSize = True
        Me.lblFaxNumber.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaxNumber.Location = New System.Drawing.Point(59, 244)
        Me.lblFaxNumber.Name = "lblFaxNumber"
        Me.lblFaxNumber.Size = New System.Drawing.Size(87, 16)
        Me.lblFaxNumber.TabIndex = 8
        Me.lblFaxNumber.Text = "Fax Number:"
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.AutoSize = True
        Me.lblTelephoneNumber.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(15, 217)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(131, 16)
        Me.lblTelephoneNumber.TabIndex = 7
        Me.lblTelephoneNumber.Text = "Telephone Number:"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(79, 190)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(67, 16)
        Me.lblZipCode.TabIndex = 6
        Me.lblZipCode.Text = "Zip Code:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(103, 163)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(43, 16)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(110, 136)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 16)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(85, 109)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 16)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(36, 82)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(110, 16)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Company Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(98, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(58, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(88, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Publisher ID:"
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PublishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.UpdateOrder = PublisherTable.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.PublishersBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(192, 33)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(283, 24)
        Me.NameComboBox.TabIndex = 5
        Me.NameComboBox.ValueMember = "Name"
        '
        'frmPublisherTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 369)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.gbPublisherInformation)
        Me.Controls.Add(Me.lblSelectPublisher)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPublisherTable"
        Me.Text = "Publisher Information Viewer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbPublisherInformation.ResumeLayout(False)
        Me.gbPublisherInformation.PerformLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents mnuPublishers As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblSelectPublisher As Label
    Friend WithEvents gbPublisherInformation As GroupBox
    Friend WithEvents lblFaxNumber As Label
    Friend WithEvents lblTelephoneNumber As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents ContactsDataSet As ContactsDataSet
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As ContactsDataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents TableAdapterManager As ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents PubIDLabel1 As Label
    Friend WithEvents FaxLabel1 As Label
    Friend WithEvents TelephoneLabel1 As Label
    Friend WithEvents ZipLabel1 As Label
    Friend WithEvents StateLabel1 As Label
    Friend WithEvents CityLabel1 As Label
    Friend WithEvents AddressLabel1 As Label
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents Company_NameLabel1 As Label
End Class
