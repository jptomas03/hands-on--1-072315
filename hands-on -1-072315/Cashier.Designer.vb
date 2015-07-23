<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
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
        Me.Counter1Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.OriginalPriceLabel = New System.Windows.Forms.Label()
        Me.TenPercercentOffLabel = New System.Windows.Forms.Label()
        Me.ItemTB = New System.Windows.Forms.TextBox()
        Me.PriceTB = New System.Windows.Forms.TextBox()
        Me.TenPercentOffTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DiscountedPriceTB = New System.Windows.Forms.TextBox()
        Me.DiscountedPriceLabel = New System.Windows.Forms.Label()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Counter1Label
        '
        Me.Counter1Label.AutoSize = True
        Me.Counter1Label.Location = New System.Drawing.Point(135, 40)
        Me.Counter1Label.Name = "Counter1Label"
        Me.Counter1Label.Size = New System.Drawing.Size(53, 13)
        Me.Counter1Label.TabIndex = 0
        Me.Counter1Label.Text = "Counter 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 4
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Location = New System.Drawing.Point(66, 74)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(58, 13)
        Me.ItemLabel.TabIndex = 5
        Me.ItemLabel.Text = "Item Name"
        '
        'OriginalPriceLabel
        '
        Me.OriginalPriceLabel.AutoSize = True
        Me.OriginalPriceLabel.Location = New System.Drawing.Point(66, 102)
        Me.OriginalPriceLabel.Name = "OriginalPriceLabel"
        Me.OriginalPriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.OriginalPriceLabel.TabIndex = 6
        Me.OriginalPriceLabel.Text = "Price"
        '
        'TenPercercentOffLabel
        '
        Me.TenPercercentOffLabel.AutoSize = True
        Me.TenPercercentOffLabel.Location = New System.Drawing.Point(66, 132)
        Me.TenPercercentOffLabel.Name = "TenPercercentOffLabel"
        Me.TenPercercentOffLabel.Size = New System.Drawing.Size(44, 13)
        Me.TenPercercentOffLabel.TabIndex = 7
        Me.TenPercercentOffLabel.Text = "10% Off"
        '
        'ItemTB
        '
        Me.ItemTB.Location = New System.Drawing.Point(145, 62)
        Me.ItemTB.Name = "ItemTB"
        Me.ItemTB.Size = New System.Drawing.Size(100, 20)
        Me.ItemTB.TabIndex = 8
        '
        'PriceTB
        '
        Me.PriceTB.Location = New System.Drawing.Point(145, 87)
        Me.PriceTB.Name = "PriceTB"
        Me.PriceTB.Size = New System.Drawing.Size(100, 20)
        Me.PriceTB.TabIndex = 9
        '
        'TenPercentOffTB
        '
        Me.TenPercentOffTB.Location = New System.Drawing.Point(145, 113)
        Me.TenPercentOffTB.Name = "TenPercentOffTB"
        Me.TenPercentOffTB.ReadOnly = True
        Me.TenPercentOffTB.Size = New System.Drawing.Size(100, 20)
        Me.TenPercentOffTB.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComputeButton)
        Me.GroupBox1.Controls.Add(Me.DiscountedPriceTB)
        Me.GroupBox1.Controls.Add(Me.DiscountedPriceLabel)
        Me.GroupBox1.Controls.Add(Me.TenPercentOffTB)
        Me.GroupBox1.Controls.Add(Me.ItemTB)
        Me.GroupBox1.Controls.Add(Me.PriceTB)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 231)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DiscountedPriceTB
        '
        Me.DiscountedPriceTB.Location = New System.Drawing.Point(147, 140)
        Me.DiscountedPriceTB.Name = "DiscountedPriceTB"
        Me.DiscountedPriceTB.ReadOnly = True
        Me.DiscountedPriceTB.Size = New System.Drawing.Size(100, 20)
        Me.DiscountedPriceTB.TabIndex = 13
        '
        'DiscountedPriceLabel
        '
        Me.DiscountedPriceLabel.AutoSize = True
        Me.DiscountedPriceLabel.Location = New System.Drawing.Point(54, 147)
        Me.DiscountedPriceLabel.Name = "DiscountedPriceLabel"
        Me.DiscountedPriceLabel.Size = New System.Drawing.Size(82, 13)
        Me.DiscountedPriceLabel.TabIndex = 12
        Me.DiscountedPriceLabel.Text = "Discouted Price"
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(60, 179)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(185, 23)
        Me.ComputeButton.TabIndex = 14
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 255)
        Me.Controls.Add(Me.TenPercercentOffLabel)
        Me.Controls.Add(Me.OriginalPriceLabel)
        Me.Controls.Add(Me.ItemLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Counter1Label)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cashier"
        Me.Text = "Troy Toys Company Cashier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Counter1Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemLabel As System.Windows.Forms.Label
    Friend WithEvents OriginalPriceLabel As System.Windows.Forms.Label
    Friend WithEvents TenPercercentOffLabel As System.Windows.Forms.Label
    Friend WithEvents ItemTB As System.Windows.Forms.TextBox
    Friend WithEvents PriceTB As System.Windows.Forms.TextBox
    Friend WithEvents TenPercentOffTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountedPriceTB As System.Windows.Forms.TextBox
    Friend WithEvents DiscountedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents ComputeButton As System.Windows.Forms.Button

End Class
