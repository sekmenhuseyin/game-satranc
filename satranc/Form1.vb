'Imports AgentObjects 'biz ekledik
'�STTEK� KODU A�IN
Public Class Form1

    ' Korh@n Geri� prestige 2005'

    ' Design hakk�nda a��klama '

    '�ncelikle butonlar yerle�tirildi ve aktif path te bulunan resimlerimiz
    'ilk ba�lama dizili�ine g�re dizildi..
    ' sonra yerle�tirilen butonlar�n yn taraflar�na labellar ile numaraland�rma
    've renklendirilme yap�ld�...
    ' form un maximumsize, minimumsize �zellikleri false yap�ld� ve formborderstyle
    '�zelli�i none yap�ld�...
    ' ve programdan ��kmak i�in bir tane buton koyuldu...
    ' a1 label � baz al�narak di�er labellar�n yani tahta elemanlar�n�n kullan�lacak
    'olan eventleri a1 label �n�nkine y�nlendirildi... '

    ' program�n i�leyi�i hakk�nda '
    'yap�lan kontrollerin hepsi string de�erler sayesinde yap�l�yor,
    ' bunun i�in ta�lar� isimlendirdim ve tahtay� olu�turan labellar�n text
    'de�erlerini kulland�m.. asl�nda ayn� i�lemi text de�erleri kullanmadan
    'yeni bir string matrisle ya da 1 ve 0 lar kullan�larak bir byte
    'dizisiyle de yapabilirdik..dizi adres te g�sterilen kodu 
    'kapat�rsak isimlerini de g�rme f�rsat� bulmu� oluruz.. '

    'ek olarak project men�s�nden
    'add reference\com yapra��ndan\agent control u projemize dahil ettik
    've using ifadelerinde tan�tt�k...'

#Region "global de�i�kenler"
    'kullan�lmak �zere agent nesnesi tan�mlan�yor..
    'Dim satranc As New AgentObjects.Agent()
    '�STTEK� B�R SATIR KODU A�IN

    'kare say�s� kadar label i�eren bir matris olu�turuluyor'
    Dim dizi_label(7, 7) As Label
    'beyaz ta�lar ve siyah ta�lar ayr� dizilere al�n�yor
    Dim beyaz_taslar(15) As String
    Dim siyah_taslar(15) As String

    Dim image_tas�, bos_image As Image
    'label dan gelen ta�� g�t�r ve sonradan imageleri bo�altmak i�in
    'bo� bir resim(image) olu�turuldu

    Dim sil, arkaplan As New Label()
    'image i al�nan� s�r�kle b�rak ger�ekle�ince sil'
    'listbox1 e hamle say�s�n� yazd�rmak i�in kullan�l�cak
    Dim k_hamle As Integer = 0
    'ilk siyah tan ba�lat ayn� renk iki kere oynamas�n
    Dim si As String = "s"
    Dim qi, pj As Integer 'mouse move dan gelen eleman�n matris de�erleri
    Dim kim As String 'b ise beyaz 's ise siyah 
    Dim tas As String 'move dan gelen tas�n ne oldu�unu tut
    Dim tut As Label()
    'rok yapabilmek i�in ilk tan�mlama i�in 
    'hareket etmedi�ini g�steren de�i�kenler tan�mland�
    'e�er hareket ederse false de�eri al�cak ve rok ger�ekle�miyecek
    Dim s_sah As Boolean = True, b_sah As Boolean = True
    Dim s_kale1 As Boolean = True, s_kale2 As Boolean = True
    Dim b_kale1 As Boolean = True, b_kale2 As Boolean = True
#End Region

#Region "prosed�rler"

    'ALTTAK� PROSED�R�N KODUNU A�IN
    'Private Sub agent_nesnesi()
    '    'agent nesnesinin kullan�m�na �rnek
    '    satranc = New AgentObjects.Agent()
    '    satranc.Connected = True
    '    satranc.Characters.Load("korhan", "merlin.acs")
    '    'merlin d���nda agent nesneleri de var istenirse kullan�labilir..
    '    satranc.Characters.Character("korhan").AutoPopupMenu = False
    '    satranc.Characters.Character("korhan").Show(50)
    '    'nesneyi show metoduyla g�ster
    '    satranc.Characters.Character("korhan").Speak("Oynamak istedi�inize eminmisiniz?", "")
    '    'konu�turmak i�in speak metodu kullan�l�yor
    '    satranc.Characters.Character("korhan").MoveTo(0, CShort((Screen.PrimaryScreen.Bounds.Size.Height - 200)), 5)
    '    'move metoduyla hareket ettiriliyor
    '    satranc.Characters.Character("korhan").Speak("yard�m isteseniz ben hep burday�m :)", "")
    '    satranc.Characters.Character("korhan").Think("�ah �ekmeyi biliyorlar m� acaba?")
    '    satranc.Characters.Character("korhan").SoundEffectsOn = True
    '    'sesi a�
    '    satranc.Characters.Character("korhan").Speak("art�k susucam", "")
    '    satranc.Characters.Character("korhan").IdleOn = True
    'End Sub

    Private Sub diziye_al()
        'matrisin elemanlar�n� tan�mlad���m�z label dizisine al�yoruz
        'biraz garip gelebilir ama i sutun j sat�r bunun sebebi ise yap�lan 
        'isimlendirmeden kaynaklan�yor..
        dizi_label(0, 0) = a1
        dizi_label(1, 0) = b1
        dizi_label(2, 0) = c1
        dizi_label(0, 1) = a2
        dizi_label(1, 1) = b2
        dizi_label(2, 1) = c2
        dizi_label(0, 2) = a3
        dizi_label(1, 2) = b3
        dizi_label(2, 2) = c3
        dizi_label(0, 3) = a4
        dizi_label(1, 3) = b4
        dizi_label(2, 3) = c4
        dizi_label(0, 4) = a5
        dizi_label(1, 4) = b5
        dizi_label(2, 4) = c5
        dizi_label(0, 5) = a6
        dizi_label(1, 5) = b6
        dizi_label(2, 5) = c6
        dizi_label(0, 6) = a7
        dizi_label(1, 6) = b7
        dizi_label(2, 6) = c7
        dizi_label(0, 7) = a8
        dizi_label(1, 7) = b8
        dizi_label(2, 7) = c8

        dizi_label(3, 0) = d1
        dizi_label(4, 0) = e1
        dizi_label(5, 0) = f1
        dizi_label(3, 1) = d2
        dizi_label(4, 1) = e2
        dizi_label(5, 1) = f2
        dizi_label(3, 2) = d3
        dizi_label(4, 2) = e3
        dizi_label(5, 2) = f3
        dizi_label(3, 3) = d4
        dizi_label(4, 3) = e4
        dizi_label(5, 3) = f4
        dizi_label(3, 4) = d5
        dizi_label(4, 4) = e5
        dizi_label(5, 4) = f5
        dizi_label(3, 5) = d6
        dizi_label(4, 5) = e6
        dizi_label(5, 5) = f6
        dizi_label(3, 6) = d7
        dizi_label(4, 6) = e7
        dizi_label(5, 6) = f7
        dizi_label(3, 7) = d8
        dizi_label(4, 7) = e8
        dizi_label(5, 7) = f8

        dizi_label(6, 0) = g1
        dizi_label(7, 0) = h1
        dizi_label(6, 1) = g2
        dizi_label(7, 1) = h2
        dizi_label(6, 2) = g3
        dizi_label(7, 2) = h3
        dizi_label(6, 3) = g4
        dizi_label(7, 3) = h4
        dizi_label(6, 4) = g5
        dizi_label(7, 4) = h5
        dizi_label(6, 5) = g6
        dizi_label(7, 5) = h6
        dizi_label(6, 6) = g7
        dizi_label(7, 6) = h7
        dizi_label(6, 7) = g8
        dizi_label(7, 7) = h8
    End Sub

    Private Sub dizi_adres()
        'beyaz ve siyah ta�lar�n isimlendirilmesi yap�l�yor..
        beyaz_taslar(0) = "b_kale1"
        beyaz_taslar(7) = "b_kale2"
        beyaz_taslar(1) = "b_at1"
        beyaz_taslar(6) = "b_at2"
        beyaz_taslar(2) = "b_fil1"
        beyaz_taslar(5) = "b_fil2"
        beyaz_taslar(3) = "b_vezir1"
        beyaz_taslar(4) = "b_sah1"
        beyaz_taslar(8) = "b_piyon1"
        beyaz_taslar(9) = "b_piyon2"
        beyaz_taslar(10) = "b_piyon3"
        beyaz_taslar(11) = "b_piyon4"
        beyaz_taslar(12) = "b_piyon5"
        beyaz_taslar(13) = "b_piyon6"
        beyaz_taslar(14) = "b_piyon7"
        beyaz_taslar(15) = "b_piyon8"

        siyah_taslar(0) = "s_kale1"
        siyah_taslar(7) = "s_kale2"
        siyah_taslar(1) = "s-at1"
        siyah_taslar(6) = "s_at2"
        siyah_taslar(2) = "s_fil1"
        siyah_taslar(5) = "s_fil2"
        siyah_taslar(3) = "s_vezir1"
        siyah_taslar(4) = "s_sah1"
        siyah_taslar(8) = "s_piyon1"
        siyah_taslar(9) = "s_piyon2"
        siyah_taslar(10) = "s_piyon3"
        siyah_taslar(11) = "s_piyon4"
        siyah_taslar(12) = "s_piyon5"
        siyah_taslar(13) = "s_piyon6"
        siyah_taslar(14) = "s_piyon7"
        siyah_taslar(15) = "s_piyon8"

        'yap�lan i�lemler labellar�n text de�erlerinde yaz�lan de�erlere g�re
        'oldu�undan ta�lar�n isimlerini labellar�n textine yaz�yoruz...
        Dim i As Integer
        For i = 0 To 7
            '�nce beyaz ta�lar i�in yap�l�yor
            dizi_label(i, 0).Text = beyaz_taslar(i)
            dizi_label(i, 1).Text = beyaz_taslar(i + 8)
            'ta�lar�n isimleri g�z�kmesin diye yaz�lar� kapat�yoruz
            dizi_label(i, 0).ForeColor = dizi_label(i, 0).BackColor
            dizi_label(i, 1).ForeColor = dizi_label(i, 1).BackColor
        Next
        For i = 0 To 7
            'sonra siyah ta�lar i�in yap�l�yor
            dizi_label(i, 7).Text = siyah_taslar(i)
            dizi_label(i, 6).Text = siyah_taslar(i + 8)
            dizi_label(i, 7).ForeColor = dizi_label(i, 7).BackColor
            dizi_label(i, 6).ForeColor = dizi_label(i, 6).BackColor
        Next
    End Sub

    Private Sub genel(ByVal i As Integer, ByVal j As Integer)
        Me.Refresh()
        'ta��d�ktan sonra bo�altmak i�in label de�erini al
        arkaplan.BackColor = dizi_label(i, j).BackColor
        'de�erini aktaracak olan label � sile al
        sil = dizi_label(i, j)
        dizi_label(i, j).ForeColor = dizi_label(i, j).BackColor
        'image i ta��mak i�in al
        image_tas� = dizi_label(i, j).Image
        dizi_label(i, j).DoDragDrop(dizi_label(i, j).Image, DragDropEffects.Move)
    End Sub

    Private Sub genel_dragdrop(ByVal i As Integer, ByVal j As Integer)
        'kendisinin �zerine b�rak�lmazsa
        'me.Refresh() 
        If Not (tut Is dizi_label(i, j)) Then
            If (kim <> si) Then
                'tekrar oynamas�n� engelle
                'image i ta��
                dizi_label(i, j).Image = image_tas�
                dizi_label(i, j).Text = sil.Text
                'image i ta��d�ktan sonra label �n image ini sil
                sil.BackColor = arkaplan.BackColor
                'ta��nd�ktan sonra textde�erleri tekrar g�z�kmesin diye 
                dizi_label(i, j).ForeColor = dizi_label(i, j).BackColor
                sil.Text = ""
                sil.Image = bos_image

                'rok yap�l�p yap�lmad���n� anlamak i�in iki tarafl� kontrol olmas�
                'gerekiyor..yani hem kale hemde �ah i�in...
                If ("kale" = dizi_label(i, j).Text.Substring(2, dizi_label(i, j).Text.Length - 3)) Then
                    kale_rok(i, j)
                ElseIf ("sah" = dizi_label(i, j).Text.Substring(2, dizi_label(i, j).Text.Length - 3)) Then

                    If (sah2(i, j)) Then
                        roku_tamamla(i, j)
                    End If
                    sah_rok(i, j)
                End If

                If (si = "s") Then 'rengi de�i�tir
                    'listbox a nerden nereye geldi�ini yaz
                    k_hamle += 1
                    listBox1.Items.Add(k_hamle)
                    listBox2.Items.Add(dizi_label(qi, pj).Name + " " + dizi_label(i, j).Name)
                    si = "b"
                Else
                    'listbox a nerden nereye geldi�ini yaz
                    listBox3.Items.Add(dizi_label(qi, pj).Name + " " + dizi_label(i, j).Name)
                    si = "s"
                End If
            Else 'kendisinin �zerine b�rak�l�rsa

                sil.BackColor = arkaplan.BackColor
                sil.Image = image_tas�
            End If
        End If
    End Sub

    Private Sub genel_dragover(ByVal i As Integer, ByVal j As Integer, ByVal a As DragEventArgs)
        Try
            Dim devam As Boolean = False
            Select Case (tas)
                'tas a g�re prosed�r� �a��r cevab�n� al
                Case "kale"
                    devam = kale(i, j)
                    Exit Select
                Case "at"
                    devam = at(i, j)
                    Exit Select
                Case "fil"
                    devam = fil(i, j)
                    Exit Select
                Case "vezir"
                    devam = vezir(i, j)
                    Exit Select
                Case "sah"
                    devam = sah(i, j, kim)
                    Exit Select
                Case "piyon"
                    devam = piyon(i, j, kim)
                    Exit Select
            End Select

            If ((dizi_label(i, j).Text = "") And (devam = True)) Then
                'TEXT DE�ER� bo� ise i�lemi yap
                a.Effect = DragDropEffects.Move
                devam = False
                Return
            Else
                'DE��LSE
                Dim gelen As String = dizi_label(i, j).Text.Substring(0, 1)
                If ((kim <> gelen) And (devam = True)) Then
                    'ayn� renk de�ilse yap
                    a.Effect = DragDropEffects.Move
                    devam = False
                    Return
                Else
                    'ayn� renkse yapma
                    sil.BackColor = arkaplan.BackColor
                    sil.Image = image_tas�
                    devam = False
                    Return
                End If
            End If

        Catch
        End Try
        'hata ��karsa k�r�lmas�n� engellemek i�in'}
    End Sub

    Private Function kale(ByVal i As Integer, ByVal j As Integer) As Boolean
        'kalenin sadece d�z gitmesinden dolay� move dan gelen matris de�i�kenlerini 
        'al�yoruz ve sat�r ile sutunu sabit tutarak kendisinin d���ndaki a�a�� ve yukar�
        'hat �zerine b�rak�lmas� durumunda drag over k�sm�na true d�nd�r�yoruz
        Dim k, l As Integer

        If (i = qi) Then
            For k = 0 To 7
                If (pj = k) Then
                    'ayn� matris olmu� oldu�undan tekrar for a ��k
                    Continue For
                ElseIf (k = j) Then
                    If (pj > j) Then
                        'arada  ta� olmas�n
                        For l = j + 1 To pj - 1
                            If (dizi_label(i, l).Text <> "") Then
                                Return False
                            End If
                        Next
                    Else
                        For l = pj + 1 To j - 1
                            If (dizi_label(i, l).Text <> "") Then
                                Return False
                            End If
                        Next
                    End If

                    Return True
                End If
            Next

        ElseIf (j = pj) Then

            For k = 0 To 7
                If (qi = k) Then
                    Continue For
                ElseIf (k = i) Then

                    If (qi > i) Then
                        'arada  ta� olmas�n
                        For l = i + 1 To qi - 1
                            If (dizi_label(l, j).Text <> "") Then
                                Return False
                            End If
                        Next

                    Else

                        For l = qi + 1 To i - 1
                            If (dizi_label(l, j).Text <> "") Then
                                Return False
                            End If
                        Next
                    End If

                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Function at(ByVal i As Integer, ByVal j As Integer) As Boolean

        'i+2 ve i-2 basaca�� kareler i�in
        'basabilece�i j-1 ve j+1 karesi
        'at�n basabilece�i bir 5 e 5 kare �izilip at�n gelece�i
        'kare i,j olarak tan�mlan�rsa 
        'de�i�memekle beraber benim matrisimde i s�tunu j sat�r� g�stermi� oluyor
        '��nk� satran� tahtas�na g�re (labellar�n name ine g�re) yerle�tirdim....
        'burada ise i sat�r j s�tunmu� gibi yazd�m....
        '((i+2),(j-2)) ((i+2),(j-1)) ((i+2),(j)) ((i+2),(j+1)) ((i+2),(j+2))
        '((i+1),(j-2))                                         ((i+1),(j+2)) 
        '((i)  ,(j-2))				   (i,j)i�in				((i)  ,(j+2))
        '((i-1),(j-2))											((i-1),(j+2))
        '((i-2),(j-2)) ((i-2),(j-1)) ((i-2),(j)) ((i-2),(j+1)) ((i-2),(j+2))
        '
        If (((i + 2) = qi) Or ((i - 2) = qi)) Then
            If ((pj = (j - 1)) Or (pj = (j + 1))) Then
                Return True
            End If
        ElseIf (((j + 2) = pj) Or ((j - 2) = pj)) Then
            If ((qi = (i - 1)) Or (qi = (i + 1))) Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Function fil(ByVal i As Integer, ByVal j As Integer) As Boolean
        Dim k, l As Integer
        For k = 0 To 7
            'en d��taki for ve  d��taki if ler �apraz gitmeyi sorguluyor
            If ((qi = (i + k)) And (pj = (j + k))) Then

                For l = 1 To k - 1  '1 den ba�lat�yorum ��nk� en yak�ndakini yiyebilmeli
                    'i�teki forlar ve if ler ise arada bi�ey varsa 
                    'ileriye gitmemesini engelliyor..
                    If (dizi_label((i + l), (j + l)).Text <> "") Then
                        Return False
                    End If
                Next

                Return True

            ElseIf ((qi = (i - k)) And (pj = (j + k))) Then

                For l = 1 To k - 1
                    If (dizi_label((i - l), (j + l)).Text <> "") Then
                        Return False
                    End If
                Next
                Return True

            ElseIf ((qi = (i - k)) And (pj = (j - k))) Then

                For l = 1 To k - 1
                    If (dizi_label((i - l), (j - l)).Text <> "") Then
                        Return False
                    End If
                Next
                Return True

            ElseIf ((qi = (i + k)) And (pj = (j - k))) Then

                For l = 1 To k - 1
                    If (dizi_label((i + l), (j - l)).Text <> "") Then
                        Return False
                    End If
                Next
                Return True
            End If

        Next

        Return False
    End Function

    Private Function piyon(ByVal i As Integer, ByVal j As Integer, ByVal kim As String) As Boolean
        'siyah ve beyaz piyon i�in ayr� ayr� yazmam gerekti.....

        If (kim = "b") Then

            If (qi = i) Then
                If ((pj = 1) And (j = pj + 2) And (dizi_label(i, j).Text = "")) Then
                    Return True
                ElseIf ((j = pj + 1) And (dizi_label(i, j).Text = "")) Then
                    Return True
                End If
            End If

            If ((i = qi + 1) Or (i = qi - 1)) Then
                'kar�� taraf�n ta��n� yiyebilmesi i�in
                If ((j = pj + 1) And (dizi_label(i, j).Text <> "")) Then
                    Return True
                End If
            End If


        Else

            If (qi = i) Then

                If ((pj = 6) And (j = pj - 2) And (dizi_label(i, j).Text = "")) Then
                    Return True
                ElseIf ((j = pj - 1) And (dizi_label(i, j).Text = "")) Then
                    Return True
                End If
            End If
            If ((i = qi + 1) Or (i = qi - 1)) Then
                'kar�� taraf�n ta��n� yiyebilmesi i�in
                If ((j = pj - 1) And (dizi_label(i, j).Text <> "")) Then
                    Return True
                End If
            End If

        End If
        Return False
    End Function

    Private Function vezir(ByVal i As Integer, ByVal j As Integer) As Boolean

        'vezir zaten fil + kale fonksiyonlar�na sahip oldu�undan 
        'iki fonksiyondan olumlu yan�t al�nmas� halinde i�lem ger�ekle�iyor
        If ((kale(i, j)) Or (fil(i, j))) Then
            Return True
        End If
        Return False
    End Function

    Private Function sah(ByVal i As Integer, ByVal j As Integer, ByVal kim As String) As Boolean

        If (qi = i) Then
            If ((pj = j + 1) Or (pj = j - 1)) Then
                Return True
            End If
        ElseIf (pj = j) Then
            If ((qi = i + 1) Or (qi = i - 1)) Then
                Return True
            ElseIf ((qi = i + 2) Or (qi = i - 2)) Then
                Return rok(i, j)
            End If
        ElseIf (((qi = i + 1) And (pj = j + 1)) Or ((qi = i - 1) And (pj = j - 1))) Then
            Return True
        ElseIf (((qi = i + 1) And (pj = j - 1)) Or ((qi = i - 1) And (pj = j + 1))) Then
            Return True
        End If

        Return False

    End Function

    Private Function sah2(ByVal i As Integer, ByVal j As Integer) As Boolean
        If (pj = j) Then
            If ((i = qi + 2) Or (i = qi - 2)) Then
                Return rok(i, j)
            End If
        End If

        Return False
    End Function

    Private Function rok(ByVal i As Integer, ByVal j As Integer) As Boolean

        'roku kontrol edebilmek i�in oynanan ta�� kontrol et
        'ona g�re di�er ona ait olan�n eleman�n daha �nceki durumu kontrol ediliyor

        If (j = 0) Then
            If ((i = 2) And ((b_kale1 = True) And (b_sah = True))) Then
                Return True
            ElseIf ((i = 6) And ((b_kale2 = True) And (b_sah = True))) Then
                Return True
            End If

            Return False
        ElseIf (j = 7) Then

            If ((i = 2) And ((s_kale1 = True) And (s_sah = True))) Then
                Return True
            ElseIf ((i = 6) And ((s_kale2 = True) And (s_sah = True))) Then
                Return True
            End If

            Return False
        End If

        Return False
    End Function

    Private Sub kale_rok(ByVal i As Integer, ByVal j As Integer)
        'oynan kale i�in bi daha rok yap�lmas�n� engellemek i�in
        'onun i�in tan�mlanan bool de�i�keni false yap..
        If (((qi = 0) And (pj = 0))) Then
            b_kale1 = False
        ElseIf (((qi = 7) And (pj = 0))) Then
            b_kale2 = False
        ElseIf ((qi = 0) And (pj = 7)) Then
            s_kale1 = False
        ElseIf ((qi = 7) And (pj = 7)) Then
            s_kale2 = False
        End If
    End Sub

    Private Sub sah_rok(ByVal i As Integer, ByVal j As Integer)
        '�ah oynand�ysa roku engellemek i�in tan�mlanan de�i�keni false yap
        If (((qi = 4) And (pj = 0)) Or ((qi = 4) And (pj = 0))) Then
            b_sah = False
        ElseIf (((qi = 4) And (pj = 7)) Or ((qi = 4) And (pj = 7))) Then
            s_sah = False
        End If
    End Sub

    Public Sub roku_tamamla(ByVal i As Integer, ByVal j As Integer)

        If ((i > qi)) Then
            dizi_label(5, j).Image = dizi_label(7, j).Image
            dizi_label(5, j).Text = dizi_label(7, j).Text
            dizi_label(7, j).Text = ""
            dizi_label(7, j).Image = bos_image
        ElseIf ((i < qi)) Then
            dizi_label(3, j).Image = dizi_label(0, j).Image
            dizi_label(3, j).Text = dizi_label(0, j).Text
            dizi_label(0, j).Text = ""
            dizi_label(0, j).Image = bos_image
        End If

    End Sub

    Private Sub surukle_b�rak()
        'label 'lar�n b�rak�lma i�lemi i�in
        'allowdrop �zelli�ini a�t�m
        Dim i, j As Integer
        For i = 0 To 7
            For j = 0 To 7
                dizi_label(i, j).AllowDrop = True
            Next
        Next
    End Sub

#End Region

#Region "eventler"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'formun arka plan rengini ayarla
        Me.BackColor = Color.SteelBlue
        'label 'lar� diziye al�cak olan prosed�r� ca��r�yorum 
        diziye_al()

        'label 'lar�n s�r�kleme i�lemi i�in a��cak prosed�r� �a��r�yorum
        surukle_b�rak()

        'ta�lar�n adreslenmesi i�lemi i�in 
        dizi_adres()

        'agent_nesnesini �al��t�r�yoruz..
        'agent_nesnesi()
        '�STTEK� B�R SATIR KODU A�IN
    End Sub

    'burada dikkat edilmesi gereken konu satran� tahtas�ndaki(butonlar�n hepsi)
    'her bir kare i�in altta ki �� eventte �al���r buraya y�nlendirmeyi handles dedikten sonra 
    'istedi�imiz eventleri yaz�yoruz ve eventler buray� tetikliyor
    Private Sub a1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles a1.DragDrop, a2.DragDrop, a3.DragDrop, a4.DragDrop, a5.DragDrop, a6.DragDrop, a7.DragDrop, a8.DragDrop, b1.DragDrop, b2.DragDrop, b3.DragDrop, b4.DragDrop, b5.DragDrop, b6.DragDrop, b7.DragDrop, b8.DragDrop, c1.DragDrop, c2.DragDrop, c3.DragDrop, c4.DragDrop, c5.DragDrop, c6.DragDrop, c7.DragDrop, c8.DragDrop, d1.DragDrop, d2.DragDrop, d3.DragDrop, d4.DragDrop, d5.DragDrop, d6.DragDrop, d7.DragDrop, d8.DragDrop, e1.DragDrop, e2.DragDrop, e3.DragDrop, e4.DragDrop, e5.DragDrop, e6.DragDrop, e7.DragDrop, e8.DragDrop, f1.DragDrop, f2.DragDrop, f3.DragDrop, f4.DragDrop, f5.DragDrop, f6.DragDrop, f7.DragDrop, f8.DragDrop, g1.DragDrop, g2.DragDrop, g3.DragDrop, g4.DragDrop, g5.DragDrop, g6.DragDrop, g7.DragDrop, g8.DragDrop, h1.DragDrop, h2.DragDrop, h3.DragDrop, h4.DragDrop, h5.DragDrop, h6.DragDrop, h7.DragDrop, h8.DragDrop
        Dim i, j As Integer
        For i = 0 To 7
            For j = 0 To 7
                If (sender Is dizi_label(i, j)) Then
                    genel_dragdrop(i, j)
                End If
            Next
        Next
    End Sub

    Private Sub a1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles a1.DragOver, a2.DragOver, a3.DragOver, a4.DragOver, a5.DragOver, a6.DragOver, a7.DragOver, a8.DragOver, b1.DragOver, b2.DragOver, b3.DragOver, b4.DragOver, b5.DragOver, b6.DragOver, b7.DragOver, b8.DragOver, c1.DragOver, c2.DragOver, c3.DragOver, c4.DragOver, c5.DragOver, c6.DragOver, c7.DragOver, c8.DragOver, d1.DragOver, d2.DragOver, d3.DragOver, d4.DragOver, d5.DragOver, d6.DragOver, d7.DragOver, d8.DragOver, e1.DragOver, e2.DragOver, e3.DragOver, e4.DragOver, e5.DragOver, e6.DragOver, e7.DragOver, e8.DragOver, f1.DragOver, f2.DragOver, f3.DragOver, f4.DragOver, f5.DragOver, f6.DragOver, f7.DragOver, f8.DragOver, g1.DragOver, g2.DragOver, g3.DragOver, g4.DragOver, g5.DragOver, g6.DragOver, g7.DragOver, g8.DragOver, h1.DragOver, h2.DragOver, h3.DragOver, h4.DragOver, h5.DragOver, h6.DragOver, h7.DragOver, h8.DragOver
        Dim i, j As Integer
        For i = 0 To 7
            For j = 0 To 7
                If (sender Is dizi_label(i, j)) Then
                    If (e.KeyState = 1) Then
                        Dim a As DragEventArgs = e 'e parametresini drageventarg tipinde 
                        'bir de�i�kene al�p yolluyorum
                        genel_dragover(i, j, a)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub a1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles a1.MouseMove, a2.MouseMove, a3.MouseMove, a4.MouseMove, a5.MouseMove, a6.MouseMove, a7.MouseMove, a8.MouseMove, b1.MouseMove, b2.MouseMove, b3.MouseMove, b4.MouseMove, b5.MouseMove, b6.MouseMove, b7.MouseMove, b8.MouseMove, c1.MouseMove, c2.MouseMove, c3.MouseMove, c4.MouseMove, c5.MouseMove, c6.MouseMove, c7.MouseMove, c8.MouseMove, d1.MouseMove, d2.MouseMove, d3.MouseMove, d4.MouseMove, d5.MouseMove, d6.MouseMove, d7.MouseMove, d8.MouseMove, e1.MouseMove, e2.MouseMove, e3.MouseMove, e4.MouseMove, e5.MouseMove, e6.MouseMove, e7.MouseMove, e8.MouseMove, f1.MouseMove, f2.MouseMove, f3.MouseMove, f4.MouseMove, f5.MouseMove, f6.MouseMove, f7.MouseMove, f8.MouseMove, g1.MouseMove, g2.MouseMove, g3.MouseMove, g4.MouseMove, g5.MouseMove, g6.MouseMove, g7.MouseMove, g8.MouseMove, h1.MouseMove, h2.MouseMove, h3.MouseMove, h4.MouseMove, h5.MouseMove, h6.MouseMove, h7.MouseMove, h8.MouseMove
        Try
            Dim i, j As Integer
            For i = 0 To 7
                For j = 0 To 7
                    If (sender Is dizi_label(i, j)) Then
                        If (e.Button = MouseButtons.Left) Then
                            'ta��n ismini globalde tut ki drag over da 
                            'ona g�re eleman�n prosed�r�n eleman�n� �a��r...
                            tas = dizi_label(i, j).Text.Substring(2, dizi_label(i, j).Text.Length - 3)
                            qi = i
                            pj = j 'hareket an�ndaki matris de�erlerini globalde tut!!!
                            'renk i�in ilk harfi kes k�m de�i�kenine al
                            kim = dizi_label(i, j).Text.Substring(0, 1)
                            ' yap�lmas� gereken i�lemleri yap
                            genel(i, j)
                        End If
                    End If
                Next
            Next

        Catch
        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Application.Exit()
    End Sub
#End Region
End Class
