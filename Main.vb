'Importation des librairies
Imports System.Math
Module Main

    Sub Main()
        'Déclaration des variables
        Dim Choix As String
        Dim null As String
        Dim Version As String
        Dim Auteur As String
        Dim DOTNETVERSION As String
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
        Dim ZA As Integer
        Dim ZB As Integer
        Dim ZC As Integer
        Dim ZD As Integer
        Dim XBA As Integer
        Dim YBA As Integer
        Dim ZBA As Integer
        Dim XCB As Integer
        Dim YCB As Integer
        Dim ZCB As Integer
        Dim XAC As Integer
        Dim YAC As Integer
        Dim ZAC As Integer

        'Variables système
        Version = " 0.4.1b Windows"
        Auteur = " Vincent PARRES (vparres)"
        DOTNETVERSION = "4.5"

        'Début du Programme
Menu:
        Console.WriteLine("##############################################")
        Console.WriteLine("##          Maths ToolBox By VPARRES        ##")
        Console.WriteLine("##              " & Version & "             ##")
        Console.WriteLine("##############################################")
        Console.WriteLine()
        Console.WriteLine("Programme a lancer :")
        Console.WriteLine("----- Vecteurs (2D) -----")
        Console.WriteLine("1. Triangle rectangle ou non ?")
        Console.WriteLine("2. Quadrilatère Parallélogramme ou non ?")
        Console.WriteLine("3. Droite parallèle ou non ?")
        Console.WriteLine("----- Vecteurs (3D) -----")
        Console.WriteLine("4. Vecteurs Colinéaires ou non ?")
        Console.WriteLine("5. Test de l'alignement de 3 points")
        Console.WriteLine("6. Coordonnées d'un Vecteur")
        Console.WriteLine("7. Distance d'un Vecteur")
        Console.WriteLine("----- Système -----")
        Console.WriteLine("A. A Propos")
        Console.WriteLine("Q. Quitter l'Application")
        Console.Write("Entrez votre choix :")
        Choix = Console.ReadLine()
        Console.WriteLine()
        Console.Clear()
        Console.WriteLine("##############################################")
        Console.WriteLine("##          Maths ToolBox By VPARRES        ##")
        Console.WriteLine("##              " & Version & "             ##")
        Console.WriteLine("##############################################")
        Console.WriteLine()
        'Partie Vecteurs 2D
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
                    Console.WriteLine("Verdict : Le triangle est rectangle")
                Else
                    Console.WriteLine("Verdict : Le triangle n'est pas rectangle")
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
                    Console.WriteLine("Verdict : Le Quadrilatère est un parallélogramme")
                Else
                    Console.WriteLine("Verdict : Le Quadrilatère n'est pas parallélogramme")
                End If

            Case "3"
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
                    Console.WriteLine("Verdict : Les Droites sont Parralèles")
                Else
                    Console.WriteLine("Verdict : Les Droites ne sont pas parralèles")
                End If

                'Partie Vecteur 3D
            Case "4"
                Console.WriteLine("Programme : Vecteurs Colinéaires ou non ?")
                Console.WriteLine("----------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Za : ")
                ZA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Zb : ")
                ZB = Console.ReadLine()
                If (XA * YB * ZA) - (YA * XB * ZB) = 0 Then
                    Console.WriteLine("Verdict : Les Vecteurs sont Colinéaire")
                Else
                    Console.WriteLine("Verdict : Les Vecteurs ne sont pas Colinéaires")
                End If
            Case "5"
                Console.WriteLine("Programme : Test de l'alignement de 3 points")
                Console.WriteLine("-------------------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Za : ")
                ZA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Zb : ")
                ZB = Console.ReadLine()
                Console.Write("Entrez Xc : ")
                XC = Console.ReadLine()
                Console.Write("Entrez Yc : ")
                YC = Console.ReadLine()
                Console.Write("Entrez Zc : ")
                ZC = Console.ReadLine()

                XBA = XB - XA
                YBA = YB - YA
                ZBA = ZB - ZA
                XAC = XC - XA
                YAC = YC - YA
                ZAC = ZC - ZA

                If (XBA / XAC) = (YBA / YAC) = (ZBA / ZAC) Then
                    Console.WriteLine("Verdict : ABC sont alignés")
                Else
                    Console.WriteLine("Verdict : ABC ne sont pas Alignés")
                End If

            Case "6"
                Console.WriteLine("Programme : Coordonnées d'un Vecteur")
                Console.WriteLine("-----------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Za : ")
                ZA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Zb : ")
                ZB = Console.ReadLine()

                XBA = XB - XA
                YBA = YB - YA
                ZBA = ZB - ZA

                Console.WriteLine("Coordonnées du Vecteur :")
                Console.WriteLine("Xab = " & XBA)
                Console.WriteLine("Yab = " & YBA)
                Console.WriteLine("Zab = " & ZBA)

            Case "7"
                Console.WriteLine("Programme : Distance d'un Vecteur")
                Console.WriteLine("---------------------------------")
                Console.WriteLine()
                Console.Write("Entrez Xa : ")
                XA = Console.ReadLine()
                Console.Write("Entrez Ya : ")
                YA = Console.ReadLine()
                Console.Write("Entrez Za : ")
                ZA = Console.ReadLine()
                Console.Write("Entrez Xb : ")
                XB = Console.ReadLine()
                Console.Write("Entrez Yb : ")
                YB = Console.ReadLine()
                Console.Write("Entrez Zb : ")
                ZB = Console.ReadLine()

                XBA = XB - XA
                YBA = YB - YA
                ZBA = ZB - ZA
                A = Pow(XBA, 2) + Pow(YBA, 2) + Pow(ZBA, 2)
                B = Sqrt(A)

                Console.WriteLine("Distance du Vecteur :")
                Console.WriteLine("AB² = " & A)
                Console.WriteLine("√(AB) = " & B)
                'Partie Système
            Case "A"
                Console.WriteLine("A Propos ...")
                Console.WriteLine("------------------------------------")
                Console.WriteLine()
                Console.WriteLine("Maths ToolBox")
                Console.WriteLine("Version :" & Version)
                Console.WriteLine("Auteur :" & Auteur)
                Console.WriteLine("Version .Net Framework : " & DOTNETVERSION)
                Console.WriteLine("Ce programme codé en VB.Net est ")
                Console.WriteLine("Open-Source et Libre de droits.")
            Case "8", "9"
                Console.WriteLine("/!\ Erreur")
                Console.WriteLine("------------------------------------")
                Console.WriteLine("Fonction non implentée !")
            Case "Q"
                End
            Case Else
                Console.WriteLine("/!\ Erreur")
                Console.WriteLine("------------------------------------")
                Console.WriteLine("Choix incorrect !")
                Console.WriteLine("Retour au Menu ...")

        End Select
        null = Console.ReadLine()
        Console.Clear()
        GoTo Menu
    End Sub

End Module
