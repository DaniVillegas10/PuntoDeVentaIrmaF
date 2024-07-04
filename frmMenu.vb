Imports System.Data.SqlTypes

Public Class frmMenu

    Private Sub ToolStripSplitButton4_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripMenu.ItemClicked

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerDateTime.Start()
        lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerDateTime.Tick
        lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub ToolStripButton5_ButtonClick(sender As Object, e As EventArgs) Handles toolStripDropDownButton1.ButtonClick
        toolStripDropDownButton1.ShowDropDown()
    End Sub

    Private Sub toolStripDropDownButton2_ButtonClick(sender As Object, e As EventArgs) Handles toolStripDropDownButton2.ButtonClick
        toolStripDropDownButton2.ShowDropDown()
    End Sub

    Private Sub ToolStripSplitButton3_ButtonClick(sender As Object, e As EventArgs) Handles toolStripDropDownButton3.ButtonClick
        toolStripDropDownButton3.ShowDropDown()

    End Sub
End Class