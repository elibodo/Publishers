Public Class frmPublisherTable
    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)
    End Sub

    Private Sub FrmPublisherTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.ContactsDataSet.Publishers)

        ' Shows nothing at startup
        NameComboBox.SelectedIndex = -1
        PubIDLabel1.Text = ""
        NameLabel1.Text = ""
        Company_NameLabel1.Text = ""
        AddressLabel1.Text = ""
        CityLabel1.Text = ""
        StateLabel1.Text = ""
        ZipLabel1.Text = ""
        TelephoneLabel1.Text = ""
        FaxLabel1.Text = ""
    End Sub

    Private Sub MnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        ' Resets all of the labels and combobox so nothing is displaying
        NameComboBox.SelectedIndex = -1
        PubIDLabel1.Text = ""
        NameLabel1.Text = ""
        Company_NameLabel1.Text = ""
        AddressLabel1.Text = ""
        CityLabel1.Text = ""
        StateLabel1.Text = ""
        ZipLabel1.Text = ""
        TelephoneLabel1.Text = ""
        FaxLabel1.Text = ""
        mnuReset.Enabled = False
    End Sub

    Private Sub MnuPublishers_Click(sender As Object, e As EventArgs) Handles mnuPublishers.Click
        ' View all the publishers in a list on a new form
        Dim pubform As Form = Publishers
        pubform.ShowDialog()
    End Sub

    Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' View the about form
        Dim aboutform As Form = About
        aboutform.ShowDialog()
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Closes the program
        Close()
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged
        ' Checks if there is an item selected. if there is then the reset button is enables.
        ' if nothing is selected the reset button is disabled
        Dim num As Integer
        num = NameComboBox.SelectedIndex

        If (num <> -1) Then
            mnuReset.Enabled = True
        End If
    End Sub
End Class
