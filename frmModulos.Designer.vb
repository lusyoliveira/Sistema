<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnOficina = New Button()
        btnPadaria = New Button()
        btnLocadora = New Button()
        btnBanco = New Button()
        SuspendLayout()
        ' 
        ' btnOficina
        ' 
        btnOficina.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOficina.Location = New Point(112, 70)
        btnOficina.Margin = New Padding(3, 2, 3, 2)
        btnOficina.Name = "btnOficina"
        btnOficina.Size = New Size(259, 37)
        btnOficina.TabIndex = 0
        btnOficina.Text = "Oficina  Mecânica"
        btnOficina.TextAlign = ContentAlignment.MiddleLeft
        btnOficina.UseVisualStyleBackColor = True
        ' 
        ' btnPadaria
        ' 
        btnPadaria.Font = New Font("Segoe UI", 18F)
        btnPadaria.Location = New Point(112, 121)
        btnPadaria.Margin = New Padding(3, 2, 3, 2)
        btnPadaria.Name = "btnPadaria"
        btnPadaria.Size = New Size(259, 37)
        btnPadaria.TabIndex = 1
        btnPadaria.Text = "Padaria"
        btnPadaria.TextAlign = ContentAlignment.MiddleLeft
        btnPadaria.UseVisualStyleBackColor = True
        ' 
        ' btnLocadora
        ' 
        btnLocadora.Font = New Font("Segoe UI", 18F)
        btnLocadora.Location = New Point(112, 174)
        btnLocadora.Margin = New Padding(3, 2, 3, 2)
        btnLocadora.Name = "btnLocadora"
        btnLocadora.Size = New Size(259, 37)
        btnLocadora.TabIndex = 2
        btnLocadora.Text = "Locadora"
        btnLocadora.TextAlign = ContentAlignment.MiddleLeft
        btnLocadora.UseVisualStyleBackColor = True
        ' 
        ' btnBanco
        ' 
        btnBanco.Font = New Font("Segoe UI", 18F)
        btnBanco.Location = New Point(112, 224)
        btnBanco.Margin = New Padding(3, 2, 3, 2)
        btnBanco.Name = "btnBanco"
        btnBanco.Size = New Size(259, 37)
        btnBanco.TabIndex = 4
        btnBanco.Text = "Banco"
        btnBanco.TextAlign = ContentAlignment.MiddleLeft
        btnBanco.UseVisualStyleBackColor = True
        ' 
        ' frmModulos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(659, 427)
        Controls.Add(btnBanco)
        Controls.Add(btnLocadora)
        Controls.Add(btnPadaria)
        Controls.Add(btnOficina)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmModulos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Módulos"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOficina As Button
    Friend WithEvents btnPadaria As Button
    Friend WithEvents btnLocadora As Button
    Friend WithEvents btnBanco As Button

End Class
