Module Main

    Sub Main()
        'Déclaration des variables
        Dim Choix As Integer
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim XA As Integer
        Dim XB As Integer
        Dim XC As Integer
        Dim XD As Integer
        Dim YA As Integer
        Dim YB As Integer
        Dim YC As Integer
        Dim YD As Integer
        Dim XBA As Integer
        Dim YBA As Integer
        Dim XCB As Integer
        Dim YCB As Integer

        'Début du Programme
        Console.WriteLine("##############################################")
        Console.WriteLine("##       Maths Tools v0.1 By VPARRES        ##")
        Console.WriteLine("##############################################")
        Console.WriteLine()
        Console.WriteLine("Programme a lancer :")
        Console.WriteLine("----- Vecteurs -----")
        Console.WriteLine("1. Triangle rectangle ou non ?")
        Console.WriteLine("2. Quadrilatère Parallélogramme ou non ?")
        Console.WriteLine("3. Vecteurs Colinéaires ou non ?")
        Console.WriteLine("4. Test de l'alignement de 3 points")
        Console.WriteLine("5. Droite parallèle ou non ?")
        Console.WriteLine("----- Fonctions Affines -----")
        Console.WriteLine("6. Fonction croissance ou non ?")
        Console.WriteLine("7. En quel point s'annule la fonction ?")
        Console.WriteLine("8. Tarifs centre de vacances")
        Console.WriteLine("9. Promotion du Magasin")
        Console.WriteLine("10. Sortir du programme")
        Console.Write("Entrez votre choix :")
        Choix = Console.ReadLine()
        Console.WriteLine()
        Select Case Choix
            Case "1"
                Console.WriteLine("Programme : Triangle rectangle ou non ?")
                Console.WriteLine("--------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez A : ")
                A = Console.ReadLine()
                Console.Write("Entrez B : ")
                B = Console.ReadLine()
                Console.Write("Entrez C : ")
                C = Console.ReadLine()
                If C ^ 2 = A ^ 2 + B ^ 2 Then
                    Console.WriteLine("Le triangle est rectangle")
                Else
                    Console.WriteLine("Le triangle n'est pas rectangle")
                End If
            Case "2"
                Console.WriteLine("Programme : Quadrilatère Parallélogramme ou non ?")
                Console.WriteLine("------------------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Xc : ")
                XC = Console.ReadLine()
                Console.Write("Entrez Yc : ")
                YC = Console.ReadLine()
                Console.Write("Entrez Xd : ")
                XD = Console.ReadLine()
                Console.Write("Entrez Yd : ")
                YD = Console.ReadLine()
                If ((XA + XC) / 2) = ((XB + XD) / 2) And ((YA + YC) / 2) = ((YB + YC) / 2) Then
                    Console.WriteLine("Le Quadrilatère est un parallélogramme")
                Else
                    Console.WriteLine("Le Quadrilatère n'est pas parallélogramme")
                End If
            Case "3"
                Console.WriteLine("Programme : Vecteurs Colinéaires ou non ?")
                Console.WriteLine("----------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez X : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Y : ")
                YA = Console.ReadLine()
                Console.Write("Entrez X' : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Y' : ")
                YB = Console.ReadLine()
                If (XA * YB) - (YA * XB) = 0 Then
                    Console.WriteLine("Vecteurs Colinéaire")
                Else
                    Console.WriteLine("Vecteurs Non Colinéaires")
                End If
            Case "4"
                Console.WriteLine("Programme : Test de l'alignement de 3 points")
                Console.WriteLine("--------------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Xc : ")
                XC = Console.ReadLine()
                Console.Write("Entrez Yc : ")
                YC = Console.ReadLine()

                XBA = XB - XA
                YBA = YB - YA
                XCB = XC - XB
                YCB = YC - YB

                If (YBA * XCB) = (YCB * XBA) Then
                    Console.WriteLine("ABC sont alignés")
                Else
                    Console.WriteLine("ABC ne sont pas Alignés")
                End If

            Case "5"
                Console.WriteLine("Programme : Droite parallèle ou non ?")
                Console.WriteLine("------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Xc : ")
                XC = Console.ReadLine()
                Console.Write("Entrez Yc : ")
                YC = Console.ReadLine()
                Console.Write("Entrez Xd : ")
                XD = Console.ReadLine()
                Console.Write("Entrez Yd : ")
                YD = Console.ReadLine()

                If (XB - XA) * (YC - YD) - (YB - YA) * (XC - XD) = 0 Then
                    Console.WriteLine("Les Droites sont Parralèles")
                Else
                    Console.WriteLine("Les Droites ne sont pas parralèles")
                End If

            Case "6", "7", "8", "9"
                Console.WriteLine("Fonction non implentée")
            Case "10"
                End

        End Select
        Console.Read()
    End Sub

End Module
