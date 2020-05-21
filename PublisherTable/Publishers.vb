Public Class Publishers

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)

    End Sub

    Private Sub Publishers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.ContactsDataSet.Publishers)

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the publisher form
        Close()
    End Sub
End Class