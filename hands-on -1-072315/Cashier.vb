Public Class Cashier

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        TenPercentOffTB.Text = PriceTB.Text * 0.1
        DiscountedPriceTB.Text = PriceTB.Text - TenPercentOffTB.Text
    End Sub
End Class
