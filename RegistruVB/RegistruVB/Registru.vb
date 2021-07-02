Public Class Registru
    Dim soldTotal As Double
    Dim cheltuieliTotal As Double
    Dim arrCheltuieli As New ArrayList
    Dim arrCheltuieliData As New ArrayList
    Dim arrSold As New ArrayList
    Dim arrSoldData As New ArrayList
    Dim arrSoldCheltuieliSold As New ArrayList
    Dim arrSoldCheltuieliData As New ArrayList
    Dim arrSoldCheltuieliCheltuieli As New ArrayList
    Dim arrSoldCheltuieliRezultat As New ArrayList
    Private Sub btnAdaugaSold_Click(sender As Object, e As EventArgs) Handles btnAdaugaSold.Click
        Dim sold As Double
        sold = InputBox("Introduceti o suma", "Adaugare sold")
        arrSold.Add(sold)
        arrSoldData.Add(Now.ToShortDateString)
        soldTotal += sold
        txtSold.Text = soldTotal.ToString()
    End Sub

    Private Sub btnAdaugaCheltuieli_Click(sender As Object, e As EventArgs) Handles btnAdaugaCheltuieli.Click
        Dim cheltuieli As Double
        cheltuieli = InputBox("Cat ati cheltuit?", "Adaugare cheltuieli")
        arrCheltuieli.Add(cheltuieli)
        arrCheltuieliData.Add(Now.ToShortDateString)
        cheltuieliTotal += cheltuieli
        txtCheltuieli.Text = cheltuieliTotal.ToString()
    End Sub

    Private Sub btnTerminaZiua_Click(sender As Object, e As EventArgs) Handles btnTerminaZiua.Click
        txtSold.Text = txtSold.Text - txtCheltuieli.Text
        arrSoldCheltuieliSold.Add(txtSold.Text)
        arrSoldCheltuieliCheltuieli.Add(txtCheltuieli.Text)
        arrSoldCheltuieliData.Add(Now.ToShortDateString)
        arrSoldCheltuieliRezultat.Add(soldTotal - txtCheltuieli.Text)
        soldTotal = soldTotal - txtCheltuieli.Text
        txtCheltuieli.Text = "0"
        cheltuieliTotal = 0
    End Sub

    Private Sub btnRaport_Click(sender As Object, e As EventArgs) Handles btnRaport.Click
        txtRaportIncasari.Text = ""
        txtRaportCheltuieli.Text = ""
        txtRaportIncasari.Text += "Data precedenta: " & Now.AddDays(-2).ToShortDateString & vbCrLf
        txtRaportCheltuieli.Text += "Data precedenta: " & Now.AddDays(-2).ToShortDateString & vbCrLf
        If arrSoldCheltuieliSold.Count > 2 Then
            txtRaportIncasari.Text += "Sold initial: " & arrSoldCheltuieliSold(arrSoldCheltuieliSold.Count - 3).ToString & vbCrLf
        Else txtRaportIncasari.Text += "Sold initial: " & "0" & vbCrLf
        End If
        'nu uita sa adaugi selectia elementului specific.
        Dim i = 0
        For Each item As String In arrSold
            If arrSoldData(i) = Now.AddDays(-2).ToShortDateString Then
                txtRaportIncasari.Text += item & vbCrLf
            End If
            i = i + 1
        Next
        i = 0
        For Each item As String In arrCheltuieli
            If arrCheltuieliData(i) = Now.AddDays(-2).ToShortDateString Then
                txtRaportCheltuieli.Text += item & vbCrLf
            End If
            i = i + 1
        Next
        i = 0
        txtRaportIncasari.Text += "Total incasari ziua precedenta: " & arrSoldCheltuieliSold(arrSoldCheltuieliSold.Count - 2) & vbCrLf
        txtRaportCheltuieli.Text += "Total cheltuieli: " & arrSoldCheltuieliCheltuieli(arrSoldCheltuieliCheltuieli.Count - 2) & vbCrLf
        txtRaportIncasari.Text += "Total incasari - cheltuieli: " & arrSoldCheltuieliRezultat(arrSoldCheltuieliRezultat.Count - 1) & vbCrLf
        txtRaportIncasari.Text += "Data actuala: " & Now.AddDays(-1).ToShortDateString & vbCrLf
        txtRaportCheltuieli.Text += "Data actuala: " & Now.AddDays(-1).ToShortDateString & vbCrLf

        txtRaportIncasari.Text += "Sold initial: " & arrSoldCheltuieliSold(arrSoldCheltuieliSold.Count - 1) & vbCrLf
        'nu uita sa adaugi selectia elementului specific.
        For Each item As String In arrSold
            If arrSoldData(i) = Now.AddDays(-1).ToShortDateString Then
                txtRaportIncasari.Text += item & vbCrLf
            End If
            i = i + 1
        Next
        i = 0
        For Each item As String In arrCheltuieli
            If arrCheltuieliData(i) = Now.AddDays(-1).ToShortDateString Then
                txtRaportCheltuieli.Text += item & vbCrLf
            End If
            i = i + 1
        Next
        txtRaportIncasari.Text += "Total incasari ziua actuala: " & arrSoldCheltuieliSold(arrSoldCheltuieliSold.Count - 1) & vbCrLf
        txtRaportCheltuieli.Text += "Total cheltuieli ziua actuala: " & arrSoldCheltuieliCheltuieli(arrSoldCheltuieliCheltuieli.Count - 1) & vbCrLf
        txtRaportIncasari.Text += "Sold final: " & arrSoldCheltuieliRezultat(arrSoldCheltuieliRezultat.Count - 1)
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        txtRaportIncasari.Text = arrSold.Count + 7
    End Sub
End Class
