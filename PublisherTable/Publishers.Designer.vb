<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Publishers
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ContactsDataSet = New PublisherTable.ContactsDataSet()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublishersTableAdapter = New PublisherTable.ContactsDataSetTableAdapters.PublishersTableAdapter()
        Me.TableAdapterManager = New PublisherTable.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.NameListBox = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(147, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 41)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.ContactsDataSet
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
        'NameListBox
        '
        Me.NameListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PublishersBindingSource, "Name", True))
        Me.NameListBox.DataSource = Me.PublishersBindingSource
        Me.NameListBox.DisplayMember = "Name"
        Me.NameListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.ItemHeight = 18
        Me.NameListBox.Location = New System.Drawing.Point(41, 57)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.ScrollAlwaysVisible = True
        Me.NameListBox.Size = New System.Drawing.Size(289, 166)
        Me.NameListBox.TabIndex = 3
        Me.NameListBox.ValueMember = "Name"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(136, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(98, 24)
        Me.lblHeader.TabIndex = 4
        Me.lblHeader.Text = "Publishers"
        '
        'Publishers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 295)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.NameListBox)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Publishers"
        Me.Text = "Publishers"
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents ContactsDataSet As ContactsDataSet
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As ContactsDataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents TableAdapterManager As ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameListBox As ListBox
    Friend WithEvents lblHeader As Label
End Class
