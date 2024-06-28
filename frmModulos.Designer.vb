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
        btnEscola = New Button()
        btnBanco = New Button()
        btnVendas = New Button()
        SuspendLayout()
        ' 
        ' btnOficina
        ' 
        btnOficina.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOficina.Location = New Point(222, 115)
        btnOficina.Name = "btnOficina"
        btnOficina.Size = New Size(296, 49)
        btnOficina.TabIndex = 0
        btnOficina.Text = "Oficina  Mecânica"
        btnOficina.TextAlign = ContentAlignment.MiddleLeft
        btnOficina.UseVisualStyleBackColor = True
        ' 
        ' btnPadaria
        ' 
        btnPadaria.Font = New Font("Segoe UI", 18F)
        btnPadaria.Location = New Point(222, 191)
        btnPadaria.Name = "btnPadaria"
        btnPadaria.Size = New Size(296, 49)
        btnPadaria.TabIndex = 1
        btnPadaria.Text = "Padaria"
        btnPadaria.TextAlign = ContentAlignment.MiddleLeft
        btnPadaria.UseVisualStyleBackColor = True
        ' 
        ' btnLocadora
        ' 
        btnLocadora.Font = New Font("Segoe UI", 18F)
        btnLocadora.Location = New Point(222, 262)
        btnLocadora.Name = "btnLocadora"
        btnLocadora.Size = New Size(296, 49)
        btnLocadora.TabIndex = 2
        btnLocadora.Text = "Locadora"
        btnLocadora.TextAlign = ContentAlignment.MiddleLeft
        btnLocadora.UseVisualStyleBackColor = True
        ' 
        ' btnEscola
        ' 
        btnEscola.Font = New Font("Segoe UI", 18F)
        btnEscola.Location = New Point(222, 327)
        btnEscola.Name = "btnEscola"
        btnEscola.Size = New Size(296, 49)
        btnEscola.TabIndex = 3
        btnEscola.Text = "Escola"
        btnEscola.TextAlign = ContentAlignment.MiddleLeft
        btnEscola.UseVisualStyleBackColor = True
        ' 
        ' btnBanco
        ' 
        btnBanco.Font = New Font("Segoe UI", 18F)
        btnBanco.Location = New Point(222, 395)
        btnBanco.Name = "btnBanco"
        btnBanco.Size = New Size(296, 49)
        btnBanco.TabIndex = 4
        btnBanco.Text = "Banco"
        btnBanco.TextAlign = ContentAlignment.MiddleLeft
        btnBanco.UseVisualStyleBackColor = True
        ' 
        ' btnVendas
        ' 
        btnVendas.Font = New Font("Segoe UI", 18F)
        btnVendas.Location = New Point(222, 460)
        btnVendas.Name = "btnVendas"
        btnVendas.Size = New Size(296, 49)
        btnVendas.TabIndex = 5
        btnVendas.Text = "Vendas"
        btnVendas.TextAlign = ContentAlignment.MiddleLeft
        btnVendas.UseVisualStyleBackColor = True
        ' 
        ' frmModulos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(btnVendas)
        Controls.Add(btnBanco)
        Controls.Add(btnEscola)
        Controls.Add(btnLocadora)
        Controls.Add(btnPadaria)
        Controls.Add(btnOficina)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmModulos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Módulos"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOficina As Button
    Friend WithEvents btnPadaria As Button
    Friend WithEvents btnLocadora As Button
    Friend WithEvents btnEscola As Button
    Friend WithEvents btnBanco As Button
    Friend WithEvents btnVendas As Button

End Class
