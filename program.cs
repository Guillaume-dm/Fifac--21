using System;

namespace Fifa_21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool D1 = true;//Test de 1er + division
            string Equipe;
            String division = " ";//Stock la division en cours
            String nom = " ";
            string team = " ";
            string adversaire = " ";//Adversaire de la J1
            int mouvant = 0;//Qualité de transfert en pts
            int domicile = 0;//Nb de buts
            int pts = 0;//Compteur de pts
            int pts_avant = 0;
            string qualification = " ";
            string qualification2 = " ";
            string Equipe_avant = " ";
            string Equipe_avant2 = " ";//Affichage sous 7 bits de votre club
            string Equipe_promu = " ";//Equipe affichant la promotion en D1
            int spectateur;//Variable de spectateurs par match
            int ouverture = 0;//Gère la journée d'ouverture en D1
            int def_v;//Gère les grandes générations aléatoire d'équipes
            int attention = 0;//Pour la division
            int l1c = 0;//Compteur de D1
            int dl2 = 0;//Compteur de D2
            int montee = 0;//Pour la promotion
            int national = 0;//Variaable de l'élimination ou non en Coupe de Françe
            Equipe = "";
            Console.WriteLine("FIFA 20");
            Console.WriteLine("Modes : 1- PROPRIETAIRE PC, 2- AUTRE");//Choix du mode de l'utilisateur
            Console.Write("Votre mode : ");
            string Utilisateur = (Console.ReadLine());
            Console.Clear();
            switch (Utilisateur)
            {
                case "1":
                    Console.WriteLine("Salut, " + System.Environment.UserName);
                    break;
                default:
                    Console.Write("Veuillez saisir votre prénom, cher entraineur : ");
                    string saisie = Console.ReadLine();
                    Console.WriteLine("Selem, " + saisie);
                    break;
            }
            string saisiee = Console.ReadLine();
            Console.WriteLine("Selem, " + saisiee);
            int saison = 1;//Compteur de saisons
            int championnats = 0;
            int coupes = 0;
            int coupe_de_france = 0;//Compteur de Coupes de Françe
            int tdc = 0;//Compteur de Trophées des Champions
            int exterieur = 0;
            while (saison < 6)
            {
                Console.ResetColor();
                int budjet;//Indique le budjet du club
                budjet = 0;
                Console.WriteLine("C'est votre saison n° " + saison);
                Console.WriteLine("Veillez saisir votre championnat : ");
                if (attention == 0)
                {
                    Console.WriteLine("1- LIGUE 1 Conforama, 2- Domino's LIGUE 2");
                }
                else
                {
                    Console.WriteLine("2- Domino's LIGUE 2");
                }
                Console.WriteLine(" ");
                Console.Write("Votre choix : ");
                int cass = Int32.Parse(Console.ReadLine());
                while (cass < 1 || cass > 3)
                {
                    Console.Write("! Veillez resaisir un choix possible : ");
                    cass = Int32.Parse(Console.ReadLine());
                }
                while (cass == 1 & attention == 1)
                {
                    Console.Write("! Veillez resaisir un choix possible : ");
                    cass = Int32.Parse(Console.ReadLine());
                }
                switch (cass)
                {
                    case 1:
                        division = "LIGUE 1 Conforama";//Mise à jour de division
                        Console.Clear();
                        Console.WriteLine("LIGUE 1 Conforama -");
                        if (Equipe_promu == " ")
                        {
                            Console.WriteLine(" 1- ANGERS SCO");
                        }
                        Console.WriteLine(" 2- GIRONDIENS DE BORDEAUX");
                        Console.WriteLine(" 3- SB 29");
                        Console.WriteLine(" 4- DFC0");
                        Console.WriteLine(" 5- LOSC");
                        Console.WriteLine(" 6- OL");
                        Console.WriteLine(" 7- OM");
                        Console.WriteLine(" 8- FC METZ");
                        Console.WriteLine(" 9- AS MONACO FC");
                        Console.WriteLine("10- FC NANTES");
                        Console.WriteLine("11- OGC NICE");
                        Console.WriteLine("12- NIMES OLYMPIQUES");
                        Console.WriteLine("13- PARIS SAINT-GERMAIN");
                        Console.WriteLine("14- SdR");
                        Console.WriteLine("15- STADE RENNAIS FC");
                        Console.WriteLine("16- A.S.S.E");
                        Console.WriteLine("17- RACING CLUB DE STRASBOURG");
                        Console.WriteLine("18- TFC");
                        if (Equipe_promu != " " & montee == 1)
                        {
                            Console.WriteLine("19- " + Equipe_promu);
                        }
                        Console.WriteLine(" ");
                        Console.Write("Votre saisie : ");
                        int casss = Int32.Parse(Console.ReadLine());
                        while (casss < 1 & montee == 0 || casss > 18 & montee == 0)
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        while (casss < 2 & montee == 1 || casss > 19 & montee == 1)
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        switch (casss)//Swtich du choix de l'équipe
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Salut, bienenue au SCO d'ANGERS !!!");
                                Equipe = "ANGERS SCO";
                                Equipe_avant2 = " ANGERS";
                                budjet = 20000000;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au GIRONDIENS DE BORDEAUX !!!");
                                Equipe = "GIRONDIENS DE BORDEAUX";
                                Equipe_avant2 = "BORDEAU";
                                budjet = 50000000;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE BRESTOIS 29 !!!");
                                Equipe = "SB 29";
                                Equipe_avant2 = " SB 29 ";
                                budjet = 20000000;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au DFCO !!!");
                                Equipe = "DFCO";
                                Equipe_avant2 = "  DFCO ";
                                budjet = 20000000;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au LOSC !!!");
                                Equipe = "LOSC";
                                Equipe_avant2 = "  LOSC ";
                                budjet = 80000000;
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Salut, bienenue à l'OL !!!");
                                Equipe = "OL";
                                Equipe_avant2 = "  OL   ";
                                budjet = 100000000;
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue à l'OM !!!");
                                Equipe = "OM";
                                Equipe_avant2 = "  OM   ";
                                budjet = 100000000;
                                break;
                            case 8:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue au FC METZ !!!");
                                Equipe = "FC METZ";
                                Equipe_avant2 = "FC METZ";
                                budjet = 20000000;
                                break;
                            case 9:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'AS MONACO FC !!!");
                                Equipe = "AS MONACO FC";
                                Equipe_avant2 = " MONACO";
                                budjet = 90000000;
                                break;
                            case 10:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Salut, bienenue au FC NANTES !!!");
                                Equipe = "FC NANTES";
                                Equipe_avant2 = " NANTES";
                                budjet = 30000000;
                                break;
                            case 11:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'OGC NICE !!!");
                                Equipe = "OGC NICE";
                                Equipe_avant2 = "  NICE ";
                                budjet = 40000000;
                                break;
                            case 12:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue à Nimes !!!");
                                Equipe = "NIMES OLYMPIQUES";
                                Equipe_avant2 = " NIMES ";
                                budjet = 20000000;
                                break;
                            case 13:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au PARIS SAINT-GERMAIN !!!");
                                Equipe = "PARIS SAINT-GERMAIN";
                                Equipe_avant2 = "  PSG  ";
                                budjet = 400000000;
                                break;
                            case 14:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE DE REIMS !!!");
                                Equipe = "STADE DE REIMS";
                                Equipe_avant2 = " REIMS ";
                                budjet = 20000000;
                                break;
                            case 15:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue au STADE RENNAIS FC !!!");
                                Equipe = "STADE RENNAIS FC";
                                Equipe_avant2 = " RENNES";
                                budjet = 35000000;
                                break;
                            case 16:
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Salut, bienenue à l'ASSE !!!");
                                Equipe = "A.S.S.E";
                                Equipe_avant2 = "A.S.S.E";
                                budjet = 40000000;
                                break;
                            case 17:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue au RACING CLUB DE STRASBOURG !!!");
                                Equipe = "RACING CLUB DE STRASBOURG";
                                Equipe_avant2 = " RACING";
                                budjet = 20000000;
                                break;
                            case 18:
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Salut, bienenue au TFC !!!");
                                Equipe = "TFC";
                                Equipe_avant2 = "  TFC  ";
                                budjet = 20000000;
                                break;
                            case 19:
                                if (Equipe_promu == "AC AJACCIO")
                                {
                                    Equipe = "ACA";
                                    Equipe_avant2 = "  ACA  ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, rebienenue à l'AC AJACCIO !!!");
                                }
                                if (Equipe_promu == "A.J AUXERRE")
                                {
                                    Equipe = "A.J AUXERRE";
                                    Equipe_avant2 = "AUXERRE";
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Salut, bienenue à l'A.J AUXERRE !!!");
                                }
                                if (Equipe_promu == "CLERMONT FOOT 63")
                                {
                                    Equipe = "CLERMONT FOOT 63";
                                    Equipe_avant2 = "CLERMON";
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Salut, bienenue au CLERMONT FOOT 63 !!!");
                                }
                                if (Equipe_promu == "GF 38")
                                {
                                    Equipe = "GF 38";
                                    Equipe_promu = " GF 38 ";
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Salut, bienenue au GF 38 !!!");
                                }
                                if (Equipe_promu == "EAG")
                                {
                                    Equipe = "EAG";
                                    Equipe_avant2 = "  EAG  ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'EN AVANT DE GUIMGUIMP !!!");
                                }
                                if (Equipe_promu == "HAC")
                                {
                                    Equipe = "HAC";
                                    Equipe_avant2 = "  HAC  ";
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Salut, bienenue au HAC !!!");
                                }
                                if (Equipe_promu == "FC LORIENT")
                                {
                                    Equipe = "FC LORIENT";
                                    Equipe_avant2 = "FC LORIENT";
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Salut, bienenue au FC LORIENT !!!");
                                }
                                if (Equipe_promu == "ASNL")
                                {
                                    Equipe = "ASNL";
                                    Equipe_avant2 = "  ASNL ";
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Salut, bienenue à l'ASNL !!!");
                                }
                                budjet = 20000000;
                                break;
                        }
                        break;
                    case 2:
                        division = "Domino's LIGUE 2";//Mise à jour de division
                        Console.Clear();
                        Console.WriteLine("Domino's LIGUE 2 -");
                        Console.WriteLine(" 1- AC AJACCIO");
                        Console.WriteLine(" 2- A.J AUXERRE");
                        Console.WriteLine(" 3- CLERMONT FOOT 63");
                        Console.WriteLine(" 4- GF 38");
                        Console.WriteLine(" 5- EAG");
                        Console.WriteLine(" 6- HAC");
                        Console.WriteLine(" 7- FC LORIENT");
                        Console.WriteLine(" 8- ASNL");
                        Console.WriteLine(" ");
                        Console.Write("Votre saisie : ");
                        casss = Int32.Parse(Console.ReadLine());
                        while (casss < 1 || casss > 9)
                        {
                            Console.Write("! Veillez resaisir une valeur correcte : ");
                            casss = Int32.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        switch (casss)//Swtich du choix de l'équipe
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'AC AJACCIO !!!");
                                Equipe = "AC AJACCIO";
                                Equipe_avant2 = "  ACA  ";
                                budjet = 11000000;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Salut, bienenue à l'A.J AUXERRE !!!");
                                Equipe = "A.J AUXERRE";
                                Equipe_avant2 = "AUXERRE";
                                budjet = 11000000;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Salut, bienenue au CLERMONT FOOT 63 !!!");
                                Equipe = "CLERMONT FOOT 63";
                                Equipe_avant2 = "CLERMON";
                                budjet = 11000000;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Salut, bienenue au GF 38 !!!");
                                Equipe = "GF 38";
                                Equipe_avant2 = " GF 38 ";
                                budjet = 11000000;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'EN AVANT DE GUIMGUIMP !!!");
                                Equipe = "EAG";
                                Equipe_avant2 = "EAG";
                                budjet = 18000000;
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Salut, bienenue au HAC !!!");
                                Equipe = "HAC";
                                Equipe_avant2 = "  HAC  ";
                                budjet = 12000000;
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Salut, bienenue au FC LORIENT !!!");
                                Equipe = "FC LORIENT";
                                Equipe_avant2 = "LORIENT";
                                budjet = 14000000;
                                break;
                            case 8:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Salut, bienenue à l'ASNL !!!");
                                Equipe = "ASNL";
                                Equipe_avant2 = "  ASNL ";
                                budjet = 12000000;
                                break;
                        }
                        break;
                }
                Console.WriteLine("BUDJET : " + budjet + " $");//Rappel du budjet du club choisi
                Console.ReadLine();
                Console.Clear();
                if (division == "LIGUE 1 Conforama")
                {
                    pts = new Random().Next(0, 82);//Calcul du nombre de pts hors transfert
                }
                else
                {
                    pts = new Random().Next(0, 85);//Calcul du nombre de pts hors transfert
                }
                Console.WriteLine("Lieu de recrutement / Prolongation de contrat :");
                Console.WriteLine("1- SECTEUR SUD-EST");
                Console.WriteLine("2- SECTEUR SUD-OUEST");
                Console.WriteLine("3- SECTEUR NORD-EST");
                Console.WriteLine("4- SECTEUR NORD-OUEST");
                Console.WriteLine("5- EUROPE");
                Console.Write("SECTEUR : ");
                string recrutement = (Console.ReadLine());
                switch (recrutement)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("BUDJET : " + budjet + " $");//Rappel du budjet du club choisi
                        Console.WriteLine(" ");
                        Console.WriteLine("AC AJACCIO");
                        Console.WriteLine("  1- M.TRAMONI*");
                        Console.WriteLine("DFCO");
                        Console.WriteLine("  2- C.HOUNTONDJI*");
                        Console.WriteLine("OL");
                        Console.WriteLine("  3- M.DEPAY*");
                        Console.WriteLine("  4- K.TETE*");
                        Console.WriteLine("OM");
                        Console.WriteLine("  5- J.AMAVI*");
                        Console.WriteLine("  6- V.GERMAIN");
                        Console.WriteLine("  7- SE.KHAOUI*");
                        Console.WriteLine("  8- M.LOPEZ*");
                        Console.WriteLine("  9- F.THAUVIN*");
                        Console.WriteLine("AS MONACO FC");
                        Console.WriteLine("  10- JORGE*");
                        Console.WriteLine("OGC NICE");
                        Console.WriteLine("  11-W.CYPRIEN*");
                        Console.WriteLine("  12-M.SARR*");
                        Console.WriteLine("  13-B.SRARFI*");
                        Console.WriteLine("ASSE");
                        Console.WriteLine("  14- B.BENKHEDIM*");
                        Console.WriteLine("  15- L.DIONY");
                        Console.WriteLine("  16- W.FOFANA*");
                        Console.WriteLine("  17- J.PORSAN-CLEMENCE*");
                        Console.WriteLine(" ");
                        Console.Write("Votre transfert : ");
                        string transfert = (Console.ReadLine());
                        Console.Clear();
                        switch (transfert)
                        {
                            case "1":
                                nom = "M.TRAMONI*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 8);
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "2":
                                nom = "C.HOUNTONDJI*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 7);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "3":
                                nom = "M.DEPAY*";
                                if (budjet >= 60000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(9, 31);
                                    pts = pts + mouvant;
                                    budjet = budjet - 60000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "4":
                                nom = "K.TETE*";
                                if (budjet >= 50000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 7);
                                    pts = pts + mouvant;
                                    budjet = budjet - 50000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "5":
                                nom = "J.AMAVI*";
                                if (budjet >= 30000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 9);
                                    pts = pts + mouvant;
                                    budjet = budjet - 30000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "6":
                                nom = "V.GERMAIN*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(3, 31);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "7":
                                nom = "SE.KHAOUI*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 7);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "8":
                                nom = "M.LOPEZ*";
                                if (budjet >= 55000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 13);
                                    pts = pts + mouvant;
                                    budjet = budjet - 55000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "9":
                                nom = "F.THAUVIN*";
                                if (budjet >= 60000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 31);
                                    pts = pts + mouvant;
                                    budjet = budjet - 60000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "10":
                                nom = "JORGE*";
                                if (budjet >= 55000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 7);
                                    pts = pts + mouvant;
                                    budjet = budjet - 55000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "11":
                                nom = "W.CYPRIEN*";
                                if (budjet >= 50000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 20);
                                    pts = pts + mouvant;
                                    budjet = budjet - 50000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "12":
                                nom = "M.SARR*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 4);
                                pts = pts + mouvant;
                                break;
                            case "13":
                                nom = "B.SRARFI*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 7);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "14":
                                nom = "B.BENKHEDIM";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = 0;
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "15":
                                nom = "L.DIONY";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 31);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "16":
                                nom = "W.FOFANA*";
                                if (budjet >= 40000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 40000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "17":
                                nom = "J.PORSAN-CLEMENTE*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = 0;
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            default:
                                nom = " ";
                                Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
                                mouvant = 0;
                                pts = pts + mouvant;
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("BUDJET : " + budjet + " $");//Rappel du budjet du club choisi
                        Console.WriteLine(" ");
                        Console.WriteLine("GIRONDIENS DE BORDEAUX");
                        Console.WriteLine("  1- N.DE PREVILLE*");
                        Console.WriteLine("  2- V.JOVANOVIC*");
                        Console.WriteLine("  3- F.KAMANO*");
                        Console.WriteLine("  4- PABLO*");
                        Console.WriteLine("  5- Y.SABALY*");
                        Console.WriteLine("MONTPELLIER HERAULT SPORTING CLUB");
                        Console.WriteLine("  6- K.DOLLY*");
                        Console.WriteLine("  7- P.MENDES");
                        Console.WriteLine("NIMES OLYMPIQUE");
                        Console.WriteLine("  8- S.ALAKOUCH*");
                        Console.WriteLine("  9- S.BEN AMAR*");
                        Console.WriteLine("TFC");
                        Console.WriteLine("  10- A.ADIL*");
                        Console.WriteLine("  11- K.AMIAN*");
                        Console.WriteLine("  12- I.SANGARE*");
                        Console.WriteLine(" ");
                        Console.Write("Votre transfert : ");
                        string transfert2 = (Console.ReadLine());
                        Console.Clear();
                        switch (transfert2)
                        {
                            case "1":
                                nom = "N.DE PREVILLE*";
                                if (budjet >= 40000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(2, 30);
                                    pts = pts + mouvant;
                                    budjet = budjet - 40000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "2":
                                nom = "V.JOVANOVIC*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 4);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "3":
                                nom = "F.KAMANO*";
                                if (budjet >= 30000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(2, 30);
                                    pts = pts + mouvant;
                                    budjet = budjet - 30000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "4":
                                nom = "PABLO*";
                                if (budjet >= 40000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(1, 7);
                                    pts = pts + mouvant;
                                    budjet = budjet - 40000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "5":
                                nom = "Y.SABALY*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 4);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "6":
                                nom = "K.DOLLY*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 5);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "7":
                                nom = "P.MENDES*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 4);
                                pts = pts + mouvant;
                                break;
                            case "8":
                                nom = "S.ALAKOUCH*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 4);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            case "9":
                                nom = "S.BEN AMAR*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = 0;
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "10":
                                nom = "A.ADIL*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = 0;
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "11":
                                if (budjet >= 30000000)
                                {
                                    nom = "K.AMIAN*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 30000000;
                                }
                                else
                                {
                                    nom = "K.AMIAN*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "12":
                                if (budjet >= 40000000)
                                {
                                    nom = "I.SANGARE*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 5);
                                    pts = pts + mouvant;
                                    budjet = budjet - 40000000;
                                }
                                else
                                {
                                    nom = "I.SANGARE*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            default:
                                nom = " ";
                                Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
                                mouvant = 0;
                                pts = pts + mouvant;
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("BUDJET : " + budjet + " $");//Rappel du budjet du club choisi
                        Console.WriteLine(" ");
                        Console.WriteLine("AJ AUXERRE");
                        Console.WriteLine("  1- A.NGANDO*");
                        Console.WriteLine("  2- H.SAKHI*");
                        Console.WriteLine("DFCO");
                        Console.WriteLine("  3- N.AGUERD*");
                        Console.WriteLine("STADE DE REIMS");
                        Console.WriteLine("  4- A.DISASI*");
                        Console.WriteLine("RACING CLUB DE STRASBOURG");
                        Console.WriteLine("  5- N.DA COSTA*");
                        Console.WriteLine("  6- B.KAMARA*");
                        Console.WriteLine("  7- K.LALA");
                        Console.WriteLine("ESTAC TROYES");
                        Console.WriteLine("  8- R.RAVELOSON*");
                        Console.WriteLine(" ");
                        Console.Write("Votre transfert : ");
                        transfert = (Console.ReadLine());
                        Console.Clear();
                        switch (transfert)
                        {
                            case "1":
                                nom = "A.NGANDO*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(1, 8);
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "2":
                                nom = "H.SAKHI*";
                                if (budjet >= 20000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 16);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "3":
                                nom = "N.AGUERD*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 7);
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "4":
                                nom = "A.DISASI*";
                                if (budjet >= 25000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 3);
                                    pts = pts + mouvant;
                                    budjet = budjet - 25000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "5":
                                nom = "N.DA COSTA*";
                                if (budjet >= 20000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(1, 22);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "6":
                                nom = "B.KAMARA*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 11);
                                pts = pts + mouvant;
                                budjet = budjet - 3000000;
                                break;
                            case "7":
                                nom = "K.LALA";
                                if (budjet >= 30000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 20);
                                    pts = pts + mouvant;
                                    budjet = budjet - 30000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "8":
                                nom = "R.RAVELOSON*";
                                Console.WriteLine("Vous avez acheté : " + nom);
                                mouvant = new Random().Next(0, 11);
                                pts = pts + mouvant;
                                budjet = budjet - 20000000;
                                break;
                            default:
                                nom = " ";
                                Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
                                mouvant = 0;
                                pts = pts + mouvant;
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("BUDJET : " + budjet + " $");//Rappel du budjet du club choisi
                        Console.WriteLine(" ");
                        Console.WriteLine("HERTA BERLIN (ALL)");
                        Console.WriteLine("  1- K.REKIK*");
                        Console.WriteLine("WOLVERHAMPTON (ANG)");
                        Console.WriteLine("  2- R.SAISS*");
                        Console.WriteLine("BETIS SEVILLE (ESP)");
                        Console.WriteLine("  3- A.MANDI*");
                        Console.WriteLine("REAL MADRID (ESP)");
                        Console.WriteLine("  4- R.RODRIGUEZ*");
                        Console.WriteLine("FIORENTINA (ITA)");
                        Console.WriteLine("  5- B.DABO*");
                        Console.WriteLine(" ");
                        Console.Write("Votre transfert : ");
                        string transfert3 = (Console.ReadLine());
                        Console.Clear();
                        switch (transfert3)
                        {
                            case "1":
                                if (budjet >= 20000000)
                                {
                                    nom = "K.REKIK*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 4);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                }
                                else
                                {
                                    nom = "K.REKIK*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "2":
                                if (budjet >= 20000000)
                                {
                                    nom = "R.SAISS*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 6);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                }
                                else
                                {
                                    nom = "R.SAISS*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "3":
                                nom = "A.MANDI*";
                                if (budjet >= 40000000)
                                {
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 15);
                                    pts = pts + mouvant;
                                    budjet = budjet - 40000000;
                                }
                                else
                                {
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "4":
                                if (budjet >= 30000000)
                                {
                                    nom = "R.RODRIGUEZ*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 31);
                                    pts = pts + mouvant;
                                    budjet = budjet - 30000000;
                                }
                                else
                                {
                                    nom = "R.RODRIGUEZ*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            case "5":
                                if (budjet >= 20000000)
                                {
                                    nom = "B.DABO*";
                                    Console.WriteLine("Vous avez acheté : " + nom);
                                    mouvant = new Random().Next(0, 12);
                                    pts = pts + mouvant;
                                    budjet = budjet - 20000000;
                                }
                                else
                                {
                                    nom = "B.DABO*";
                                    Console.WriteLine("ECHEC DE TRANSFERT : " + nom);
                                    nom = " ";
                                    mouvant = 0;
                                    pts = pts + mouvant;
                                }
                                break;
                            default:
                                nom = " ";
                                Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
                                mouvant = 0;
                                pts = pts + mouvant;
                                break;
                        }
                        break;
                    default:
                        nom = " ";
                        Console.WriteLine("AUCUN TRANSFERT EFFECTUE...");
                        mouvant = 0;
                        pts = pts + mouvant;
                        break;
                }
                Console.WriteLine("NOUVEAU BUDJET : " + budjet + " $");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("STAGE D'ETE");
                Console.WriteLine("  1- SAINT-JEAN-BONNEFONDS (42)");
                Console.WriteLine("  2- LE CHAMBON-SUR-LIGNON (43)");
                Console.WriteLine("  3- ALBERTVILLE(74)");
                Console.WriteLine("  4- EVIAN-LES-BAINS (74)");
                Console.WriteLine("  5- MURCIE (ESP)");
                Console.WriteLine("  6- LOS ANGELES (USA)");
                Console.WriteLine(" ");
                Console.Write("Votre transfert : ");
                string amical = (Console.ReadLine());
                Console.Clear();
                switch (amical)
                {
                    case "2":
                        string lieu = "LE CHAMBON-SUR-LIGNON (43)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu);
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("  AMICAL VS MONTPELLIER HERAULT SPORTING CLUB :");
                        Console.WriteLine("LIEU : STADE DU VIOUZOU (43000- ESPALY-SAINT-MARCEL)");
                        Console.ReadLine();
                        spectateur = new Random().Next(0, 3600);
                        AffichageMHSC(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);

                        break;
                    case "1":
                        if (Equipe != "A.S.S.E")
                        {
                            lieu = "SAINT-JEAN-BONNEFONDS (42)";
                            Console.WriteLine("LIEU DU STAGE : " + lieu);
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("  AMICAL VS A.S.S.E :");
                            Console.WriteLine("LIEU : ENVOL-STADIUM (42160- ANDREZIEUX-BOUTHEON)");
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 5001);
                            Console.ReadLine();
                            AffichageASSE(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                        }
                        if (Equipe != "OL")
                        {
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 4612);
                            Console.WriteLine("  AMICAL VS OL :");
                            Console.WriteLine("LIEU : STADE DARRAGON (03200- VICHY)");
                            Console.ReadLine();
                            AffichageOL(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                        }
                        break;
                    case "3":
                        lieu = "ALBERTVILLE (74)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu);
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        lieu = "EVIAN-LES-BAINS (74)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu);
                        Console.ReadLine();
                        Console.Clear();
                        if (Equipe != "AS MONACO FC")
                        {
                            domicile = new Random().Next(0, 5);
                            exterieur = new Random().Next(0, 5);
                            spectateur = new Random().Next(0, 15715);
                            Console.WriteLine("  AMICAL VS AS MONACO FC :");
                            Console.WriteLine("LIEU : PARC DES SPORTS D'EVIAN (74000- ANNECY)");
                            Console.ReadLine();
                            AffichageASM(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                        }
                        else
                        {
                            Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        lieu = "MURCIE (ESP)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu);
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        lieu = "LOS ANGELES (USA)";
                        Console.WriteLine("LIEU DU STAGE : " + lieu);
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine(Equipe + " : PAS DE MATCHS AMICAUX");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                if (Equipe == qualification || D1 == true && Equipe == Equipe_avant)
                {
                    domicile = new Random().Next(0, 4);
                    exterieur = new Random().Next(0, 4);
                    int tab = new Random().Next(0, 2);
                    spectateur = new Random().Next(0, 81339);
                    AffichageTdC(domicile, Equipe, exterieur, spectateur, Equipe_avant, qualification, tab, Equipe_avant2, qualification2);
                    Console.ReadLine();
                    Console.Clear();
                    if (domicile > exterieur || tab == 1 && domicile == exterieur)
                    {
                        tdc = tdc + 1;
                    }
                    qualification = " ";
                }
                if (Equipe == "A.S.S.E" & saison % 2 == 1 & division == "LIGUE 1 Conforama")
                {
                    ouverture = new Random().Next(2, 5);
                }
                if (Equipe == "OL" & saison % 2 == 1 & division == "LIGUE 1 Conforama")
                {
                    ouverture = new Random().Next(1, 4);
                }
                if (Equipe == "AS MONACO FC" & saison % 2 == 1 & division == "LIGUE 1 Conforama")
                {
                    ouverture = new Random().Next(1, 5);
                    while (ouverture == 2)
                    {
                        ouverture = new Random().Next(1, 5);
                    }
                }
                if (Equipe != "OL" & Equipe != "AS MONACO FC" & Equipe != "A.S.S.E" & saison % 2 == 1 & division == "LIGUE 1 Conforama")
                {
                    ouverture = new Random().Next(1, 5);
                }
                if (saison % 2 == 0)
                {
                    ouverture = 0;
                }
                if (ouverture == 1)
                {
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                        spectateur = new Random().Next(27500, 41966);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                        spectateur = new Random().Next(1000, 41966);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 CONFORAMA VS A.S.S.E :");
                    Console.WriteLine("LIEU : STADE GEOFFROY-GUICHARD (42000- SAINT-ETIENNE)");
                    Console.ReadLine();
                    AffichageASSE(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "A.S.S.E";
                }
                if (ouverture == 2)
                {
                    spectateur = new Random().Next(0, 18524);
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 CONFORAMA VS AS MONACO FC :");
                    Console.WriteLine("LIEU : STADE LOUIS-II (MONACO)");
                    Console.ReadLine();
                    AffichageASM(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "AS MONACO FC";
                }
                if (ouverture == 3)
                {
                    spectateur = new Random().Next(0, 32901);
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("   JOURNEE 1, LIGUE 1 CONFORAMA VS MONTPELLIER HERAULT SC :");
                    Console.WriteLine("LIEU : STADE DE LA MOISSON (34080- MONTPELLIER)");
                    Console.ReadLine();
                    AffichageMHSC(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "MONTPELLIER";
                }
                if (ouverture == 4)
                {
                    if (Equipe == "PARIS SAINT-GERMAIN")
                    {
                        domicile = new Random().Next(0, 4);
                        exterieur = new Random().Next(0, 6);
                        spectateur = new Random().Next(45000, 59168);
                        exterieur = 5;
                    }
                    else
                    {
                        domicile = new Random().Next(0, 5);
                        exterieur = new Random().Next(0, 5);
                        spectateur = new Random().Next(1000, 59168);
                    }
                    Console.WriteLine("  JOURNEE 1, LIGUE 1 CONFORAMA VS OL :");
                    Console.WriteLine("LIEU : GROUPAMA STADIUM");
                    Console.ReadLine();
                    AffichageOL(domicile, nom, mouvant, Equipe, pts, exterieur, spectateur);
                    adversaire = "OL";
                }
                int pt = 0;
                if (saison % 2 == 1 & division == "LIGUE 1 CONFORAMA")
                {
                    if (domicile > exterieur & saison == 1)
                    {
                        pt = 0;
                        Console.WriteLine("1er : " + adversaire + " (3 pts)");
                        Console.WriteLine("[...]");
                        Console.WriteLine("20ème : " + Equipe + " (0 pt)");
                    }
                    if (domicile == exterieur & saison == 1)
                    {
                        pt = 1;
                        Console.WriteLine("1er : " + Equipe + " (1 pt)");
                        Console.WriteLine("2ème : " + adversaire + " (1 pt)");
                    }
                    if (domicile < exterieur & saison == 1)
                    {
                        pt = 3;
                        Console.WriteLine("1er : " + Equipe + " (3 pts)");
                        Console.WriteLine("[...]");
                        Console.WriteLine("20ème : " + adversaire + " (0 pt)");
                    }
                    if (saison % 2 == 1)
                    {
                        pts = pts + pt;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                team = " ";
                if (division == "LIGUE 1 Conforama")
                {
                    national = new Random().Next(1, 65);
                }
                if (division == "Domino's LIGUE 2")
                {
                    national = new Random().Next(1, 129);
                }
                string tour = "";
                if (national == 1)
                {
                    Console.WriteLine("VAINQUEUR DE LA COUPE DE FRANCE : " + Equipe);
                    coupe_de_france = coupe_de_france + 1;
                    if (Equipe == "LOSC")
                    {
                        team = "LOSC";
                        qualification2 = "  LOSC ";
                    }
                }
                else
                {
                    if (national == 3 || national == 4)
                    {
                        tour = "DEMI-FINALE";
                    }
                    if (national == 2)
                    {
                        tour = "FINALE";
                    }
                    if (national >= 5 & national < 9)
                    {
                        tour = "QUART DE FINALE";
                    }
                    if (national > 8 & national < 17)
                    {
                        tour = "8° DE FINALE";
                    }
                    if (national > 16 & national < 33)
                    {
                        tour = "16° DE FINALE";
                    }
                    if (national >= 33 & national < 65)
                    {
                        tour = "32° DE FINALE";
                    }
                    if (national > 64)
                    {
                        tour = "64° DE FINALE";
                    }
                    Console.WriteLine(Equipe + " ELIMINE EN " + tour);
                    def_v = new Random().Next(-8, 41);
                    while (team == Equipe || team == " ")
                    {
                        def_v = new Random().Next(-8, 41);
                        if (def_v == 1)
                        {
                            team = "ANGERS SCO";
                            qualification2 = " ANGERS";
                        }
                        if (def_v == 2)
                        {
                            team = "GIRONDIENS DE BORDEAUX";
                            qualification2 = "BORDEAU";
                        }
                        if (def_v == 3)
                        {
                            team = "SB 29";
                            qualification2 = " SB 29 ";
                        }
                        if (def_v == 4)
                        {
                            team = "DFCO";
                            qualification2 = "  DFCO ";
                        }
                        if (def_v == 5)
                        {
                            team = "LOSC";
                            qualification2 = "  LOSC ";
                        }
                        if (def_v == 6)
                        {
                            team = "OL";
                            qualification2 = "  OL   ";
                        }
                        if (def_v == 7)
                        {
                            team = "OM";
                            qualification2 = "  OM   ";
                        }
                        if (def_v == 8)
                        {
                            team = "FC METZ";
                            qualification2 = "FC METZ";
                        }
                        if (def_v == 9)
                        {
                            team = "AS MONACO FC";
                            qualification2 = " MONACO";
                        }
                        if (def_v == 10)
                        {
                            team = "FC NANTES";
                            qualification2 = " NANTES";
                        }
                        if (def_v == 11)
                        {
                            team = "OGC NICE";
                            qualification2 = "  NICE ";
                        }
                        if (def_v == 12)
                        {
                            team = "NIMES OLYMPIQUES";
                            qualification2 = " NIMES ";
                        }
                        if (def_v == 13 || def_v < 1)
                        {
                            team = "PARIS SAINT-GERMAIN";
                            qualification2 = "  PSG  ";
                        }
                        if (def_v == 14)
                        {
                            team = "STADE DE REIMS";
                            qualification2 = " REIMS ";
                        }
                        if (def_v == 15)
                        {
                            team = "STADE RENNAIS FC";
                            qualification2 = " RENNES";
                        }
                        if (def_v == 16)
                        {
                            team = "A.S.S.E";
                            qualification2 = "A.S.S.E";
                        }
                        if (def_v == 17)
                        {
                            team = "RACING CLUB DE STRASBOURG";
                            qualification2 = " RACING";
                        }
                        if (def_v == 18)
                        {
                            team = "TFC";
                            qualification2 = "  TFC  ";
                        }
                        if (def_v == 19)
                        {
                            team = "AMIENS SC";
                            qualification2 = " AMIENS";
                        }
                        if (def_v == 20)
                        {
                            team = "MONTPELLIER HERAULT SPORTING CLUB";
                            qualification2 = "  MHSC ";
                        }
                        if (def_v == 21)
                        {
                            team = "FC LORIENT";
                            qualification2 = "LORIENT";
                        }
                        if (def_v == 22)
                        {
                            team = "PARIS FC";
                            qualification2 = "  PFC  ";
                        }
                        if (def_v == 23)
                        {
                            team = "QUEVILLY";
                            qualification2 = "QUEVILL";
                        }
                        if (def_v == 24)
                        {
                            team = "TOURS FC";
                            qualification2 = " TOURS ";
                        }
                        if (def_v == 25)
                        {
                            team = "ASNL";
                            qualification2 = " ASNL  ";
                        }
                        if (def_v == 26)
                        {
                            team = "CHAMOIS NIORTAIS";
                            qualification2 = "CHAMOIS";
                        }
                        if (def_v == 27)
                        {
                            team = "RED STAR FC";
                            qualification2 = "REDSTAR";
                        }
                        if (def_v == 28)
                        {
                            team = "US RAON-L'ETAPE";
                            qualification2 = " US RAON";
                        }
                        if (def_v == 29)
                        {
                            team = "LE PUY FOOT AUVERGNE";
                            qualification2 = " LE PUY";
                        }
                        if (def_v == 29)
                        {
                            team = "RODEZ AVEYRON FOOTBALL";
                            qualification2 = " RODEZ ";
                        }
                        if (def_v == 30)
                        {
                            team = "TRELISSAC FC";
                            qualification2 = "TRELISS";
                        }
                        if (def_v == 31)
                        {
                            team = "US BOULOGNE FC";
                            qualification2 = "BOULOGNE";
                        }
                        if (def_v == 32)
                        {
                            team = "U.S. CONCARNEAU";
                            qualification2 = "CONCARN";
                        }
                        if (def_v == 33)
                        {
                            team = "VANNES OLYMPIQUE CLUB";
                            qualification2 = "  VOC  ";
                        }
                        if (def_v == 34)
                        {
                            team = "FBBP 01";
                            qualification2 = "FBBP 01";
                        }
                        if (def_v == 35)
                        {
                            team = "C.A.BASTIA";
                            qualification2 = "CA BAST";
                        }
                        if (def_v == 36)
                        {
                            team = "SAS FOOTBALL EPINAL";
                            qualification2 = " EPINAL";
                        }
                        if (def_v == 37)
                        {
                            team = "VENDEE LES HERBIERS FOOTBALL";
                            qualification2 = "HERBIER";
                        }
                        if (def_v == 38)
                        {
                            team = "FC CHAMBLY 1989 OISE";
                            qualification2 = "CHAMBLY";
                        }
                        if (def_v == 39)
                        {
                            team = "ENTENTE SANNOIS SAINT GRATIEN";
                            qualification2 = "SANNOIS";
                        }
                        if (def_v == 40)
                        {
                            team = "LE MANS FC";
                            qualification2 = "LE MANS";
                        }
                    }
                    Console.WriteLine("VAINQUEUR : " + team);
                    qualification = team;
                }
                Console.ReadLine();
                Console.Clear();
                if (pts == 113)//Gestion d'un cas réel impossible
                {
                    pts = 112;
                }
                Console.WriteLine("PTS : " + pts);//Annonce des pts de la saison
                pts_avant = pts;
                Equipe_avant = " ";
                if (pts >= 80)
                {
                    Equipe_avant = Equipe;
                    Console.WriteLine("1er : " + Equipe);
                    if (pts == 112)
                    {
                        Console.WriteLine("(37-1-0)");
                    }
                    if (pts == 114)
                    {
                        Console.WriteLine("(38-0-0)");
                    }
                    if (division == "LIGUE 1 Conforama")
                    {
                        l1c = l1c + 1;
                        D1 = true;
                    }
                    else
                    {
                        dl2 = dl2 + 1;
                        D1 = false;
                    }
                }
                if (pts >= 66 & division == "Domino's LIGUE 2")
                {
                    montee = 1;
                    attention = 0;
                    D1 = false;
                    Equipe_promu = Equipe;
                }
                if (pts < 15)
                {
                    Console.WriteLine("20ème : " + Equipe);
                    if (pts == 5)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-5-33)");
                        }
                        else
                        {
                            Console.WriteLine("(1-2-35)");
                        }
                    }
                    if (pts == 4)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-4-34)");
                        }
                        else
                        {
                            Console.WriteLine("(1-1-36)");
                        }
                    }
                    if (pts == 3)
                    {
                        int cas = new Random().Next(1, 3);
                        if (cas == 1)
                        {
                            Console.WriteLine("(0-3-35)");
                        }
                        else
                        {
                            Console.WriteLine("(1-0-37)");
                        }
                    }
                    if (pts == 2)
                    {
                        Console.WriteLine("(0-2-36)");
                    }
                    if (pts == 1)
                    {
                        Console.WriteLine("(0-1-37)");
                    }
                    if (pts == 0)
                    {
                        Console.WriteLine("(0-0-38)");
                    }
                }
                if (pts < 40 & pts >= 15 & division == "LIGUE 1 Conforama")
                {
                    int classement2 = new Random().Next(19, 21);
                    int relegation = new Random().Next(1, 3);
                    int pts1 = new Random().Next(16, 41);
                    int pts2 = new Random().Next(16, 41);
                    while (pts1 <= pts || pts1 < pts2 || pts2 < pts)
                    {
                        pts1 = new Random().Next(16, 41);
                        pts2 = new Random().Next(16, 41);
                    }
                    if (relegation == 1)
                    {
                        Console.WriteLine("18ème : AMIENS SC (" + pts1 + " PTS)");
                    }
                    else
                    {
                        Console.WriteLine("18ème : MONTPELLIER HERAULT SC (" + pts1 + " PTS)");
                    }
                    if (classement2 == 19)
                    {
                        while (pts2 > pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        Console.WriteLine("19ème : " + Equipe + " (" + pts + " PTS)");
                        if (relegation == 1)
                        {
                            Console.WriteLine("20ème : MONTPELLIER HERAULT SC (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("20ème : AMIENS SC (" + pts2 + " PTS)");
                        }
                    }
                    else
                    {
                        while (pts2 <= pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        if (relegation == 1)
                        {
                            Console.WriteLine("19ème : MONTPELLIER HERAULT SC (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("19ème : AMIENS SC (" + pts2 + " PTS)");
                        }
                        Console.WriteLine("20ème : " + Equipe + " (" + pts + " PTS)");
                    }
                }
                if (pts < 40 & pts >= 15 & division == "Domino's LIGUE 2")
                {
                    if (attention == 1)
                    {
                        def_v = new Random().Next(1, 22);
                    }
                    else
                    {
                        def_v = new Random().Next(1, 20);
                    }
                    team = " ";
                    int classement2 = new Random().Next(19, 21);
                    int relegation = new Random().Next(1, 3);
                    int pts1 = new Random().Next(16, 41);
                    int pts2 = new Random().Next(16, 41);
                    while (team == Equipe || team == " ")
                    {
                        def_v = new Random().Next(1, 20);
                        if (def_v == 1)
                        {
                            team = "AC AJACCIO";
                        }
                        if (def_v == 2)
                        {
                            team = "A.J AUXERRE";
                        }
                        if (def_v == 3)
                        {
                            team = "CLERMONT FOOT 63";
                        }
                        if (def_v == 4)
                        {
                            team = "GF 38";
                        }
                        if (def_v == 5)
                        {
                            team = "EAG";
                        }
                        if (def_v == 6)
                        {
                            team = "HAC";
                        }
                        if (def_v == 7)
                        {
                            team = "FC LORIENT";
                        }
                        if (def_v == 8)
                        {
                            team = "ASNL";
                        }
                        if (def_v == 9)
                        {
                            team = "LE MANS FC";
                        }
                        if (def_v == 10)
                        {
                            team = "CHAMOIS NIORTAIS FC";
                        }
                        if (def_v == 11)
                        {
                            team = "ORLEANS LOIRET FOOTBALL USO";
                        }
                        if (def_v == 12)
                        {
                            team = "PARIS FC";
                        }
                        if (def_v == 13)
                        {
                            team = "FCSM";
                        }
                        if (def_v == 14)
                        {
                            team = "ESTAC TROYES";
                        }
                        if (def_v == 15)
                        {
                            team = "VAFC";
                        }
                        if (def_v == 16)
                        {
                            team = "FC CHAMBLY 1929 OISE";
                        }
                        if (def_v == 17)
                        {
                            team = "STADE MALHERBE DE CAEN";
                        }
                        if (def_v == 18)
                        {
                            team = "LA BERRICHONNE DE CHATEAUROUX";
                        }
                        if (def_v == 19)
                        {
                            team = "RC LENS";
                        }
                        if (def_v == 20)
                        {
                            team = "AMIENS SC";
                        }
                        if (def_v == 21)
                        {
                            team = "MONTPELLIER HERAULT SPORTING CLUB";
                        }
                    }
                    while (pts1 <= pts || pts1 < pts2 || pts2 < pts)
                    {
                        pts1 = new Random().Next(16, 41);
                        pts2 = new Random().Next(16, 41);
                    }
                    if (relegation == 1)
                    {
                        Console.WriteLine("18ème : " + team + " (" + pts1 + " PTS)");
                    }
                    else
                    {
                        Console.WriteLine("18ème : RODEZ AVEYRON FOOTBALL 1929 (" + pts1 + " PTS)");
                    }
                    if (classement2 == 19)
                    {
                        while (pts2 > pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        Console.WriteLine("19ème : " + Equipe + " (" + pts + " PTS)");
                        if (relegation == 1)
                        {
                            Console.WriteLine("20ème : RODEZ AVEYRON FOOTBALL 1929 (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("20ème : " + team + " (" + pts2 + " PTS)");
                        }
                    }
                    else
                    {
                        while (pts2 <= pts)
                        {
                            pts2 = new Random().Next(16, 41);
                        }
                        if (relegation == 1)
                        {
                            Console.WriteLine("19ème : RODEZ AVEYRON FOOTBALL 1929 (" + pts2 + " PTS)");
                        }
                        else
                        {
                            Console.WriteLine("19ème : " + team + " (" + pts2 + " PTS)");
                        }
                        Console.WriteLine("20ème : " + Equipe + " (" + pts + " PTS)");
                    }
                }
                if (division == "LIGUE 1 Conforama" & pts >= 40)
                {
                    Console.WriteLine("Votre équipe s'est maintenue en " + division + " !!!");
                }
                if (pts < 40)
                {
                    Console.WriteLine(" ");
                    if (division == "LIGUE 1 Conforama")
                    {
                        attention = 1;
                        division = "Domino's LIGUE 2";
                        Console.WriteLine(Equipe + " descend en " + division + "...");
                    }
                    else
                    {
                        attention = 2;
                        division = "NATIONAL";
                        Console.WriteLine(Equipe + " descend en " + division + "...");
                        saison = 10;
                    }
                }
                saison = saison + 1;
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("FIN DE CARRIERE...");
            championnats = l1c + dl2;
            coupes = coupe_de_france + tdc;
            if (championnats < 2)
            {
                Console.WriteLine("CHAMPIONNAT GAGNE : " + championnats);
                Console.WriteLine(" DONT LIGUE 1 Conforama : " + l1c);
                Console.WriteLine(" DONT Domino's LIGUE 2 : " + dl2);
            }
            else
            {
                Console.WriteLine("CHAMPIONNATS GAGNES : " + championnats);
                Console.WriteLine(" DONT LIGUE 1 Conforama : " + l1c);
                Console.WriteLine(" DONT Domino's LIGUE 2 : " + dl2);
            }
            if (coupes < 2)
            {
                Console.WriteLine("COUPE GAGNEE : " + coupes);
                Console.WriteLine(" DONT COUPE DE FRANCE : " + coupe_de_france);
                Console.WriteLine(" DONT TROPHEE DES CHAMPIONS : " + tdc);
            }
            else
            {
                Console.WriteLine("COUPES GAGNEES : " + coupes);
                Console.WriteLine(" DONT COUPE(S) DE FRANCE : " + coupe_de_france);
                Console.WriteLine(" DONT TROPHEE(S) DES CHAMPIONS : " + tdc);
            }
            Credit();
        }

        static void AffichageOL(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            Console.WriteLine("COMPOSITION OL (4-2-3-1)");
            string ol1 = "DUBOIS";
            string ol2 = "KONE";
            string ol3 = "DENAYER";
            string ol4 = "RAPHAEL";
            string ol5 = "TOUSART";
            string ol6 = "AOUAR";
            string ol7 = "TERRIER";
            string ol8 = "CHERKI";
            string ol9 = "TRAORE";
            string ol10 = "DEMBELE";
            string ol10bis = "DEMBELE (P)";
            Console.WriteLine(" ");
            Console.WriteLine("              1-LOPES");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" 4- " + ol4 + "  5- " + ol3 + " 28- " + ol2 + " 14- " + ol1);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       8- " + ol6 + "           29- " + ol5);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("  27- " + ol8 + "    20- " + ol9 + "     18- " + ol7);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("               9- " + ol10);
            Console.ReadLine();
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(nom + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + nom + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + nom + "[...]");
                        if (mouvant > 10 & Equipe == "A.S.S.E")
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            int buteur = 0;
            int x = 0;
            int y = 1;
            string name = " ";
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         0");
            Console.ReadLine();
            Console.Clear();
            while (y < exterieur)
            {
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                y = y + 1;
            }
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.ReadLine();
            Console.Clear();
            if (domicile > 0)
            {
                x = 1;
                buteur = new Random().Next(1, 12);
                if (buteur == 1)
                {
                    name = ol1;
                }
                if (buteur == 2)
                {
                    name = ol2;
                }
                if (buteur == 3)
                {
                    name = ol3;
                }
                if (buteur == 4)
                {
                    name = ol4;
                }
                if (buteur == 5)
                {
                    name = ol5;
                }
                if (buteur == 6)
                {
                    name = ol6;
                }
                if (buteur == 7)
                {
                    name = ol7;
                }
                if (buteur == 8)
                {
                    name = ol8;
                }
                if (buteur == 9)
                {
                    name = ol9;
                }
                if (buteur == 10)
                {
                    name = ol10;
                }
                if (buteur == 11)
                {
                    name = ol10bis;
                }
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 1)
            {
                buteur = new Random().Next(1, 11);
                x = 2;
                if (buteur == 1)
                {
                    name2 = ol1;
                }
                if (buteur == 2)
                {
                    name2 = ol2;
                }
                if (buteur == 3)
                {
                    name2 = ol3;
                }
                if (buteur == 4)
                {
                    name2 = ol4;
                }
                if (buteur == 5)
                {
                    name2 = ol5;
                }
                if (buteur == 6)
                {
                    name2 = ol6;
                }
                if (buteur == 7)
                {
                    name2 = ol7;
                }
                if (buteur == 8)
                {
                    name2 = ol8;
                }
                if (buteur == 9)
                {
                    name2 = ol9;
                }
                if (buteur == 10)
                {
                    name2 = ol10;
                }
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 2)
            {
                buteur = new Random().Next(7, 11);
                x = 3;
                if (buteur == 7)
                {
                    name3 = ol7;
                }
                if (buteur == 8)
                {
                    name3 = ol8;
                }
                if (buteur == 9)
                {
                    name3 = ol9;
                }
                if (buteur == 10)
                {
                    name3 = ol10;
                }
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 3)
            {
                buteur = new Random().Next(7, 12);
                x = 4;
                if (buteur == 7)
                {
                    name4 = ol7;
                }
                if (buteur == 8)
                {
                    name4 = ol8;
                }
                if (buteur == 9)
                {
                    name4 = ol9;
                }
                if (buteur == 10)
                {
                    name4 = ol10;
                }
                if (buteur == 11)
                {
                    name4 = ol10bis;
                }
                Console.WriteLine("  OL       " + Equipe);
                Console.WriteLine("  " + x + "         " + y);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.Clear();
            }
            Console.WriteLine("  OL       " + Equipe);
            Console.WriteLine("  " + x + "         " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
        }

        static void AffichageASSE(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            Console.WriteLine("COMPOSITION ASSE (4-2-3-1)");
            int composition = new Random().Next(0, 2);
            string asse1 = "TRAUCO";
            string asse2 = "MOUKOUDI";
            string asse3 = "M'VILA";
            string asse4 = "PALENCIA";
            string asse5 = "DIOUSSE";
            string asse6 = "YOUSSOUF";
            string asse7 = "NORDIN";
            string asse8 = "KHAZRI";
            string asse9 = "BOUANGA";
            string asse10 = "ABI";
            string asse9bis = "BOUANGA (P)";
            Console.WriteLine(" ");
            Console.WriteLine("             40-BAJIC");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("23- " + asse4 + "  6- " + asse3 + "  2- " + asse2 + " 13- " + asse1);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("      28- " + asse6 + "           25- " + asse5);
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 1)
            {
                asse8 = "HONORAT";
                Console.WriteLine("  14- " + asse8 + "    20- " + asse9 + "     18- " + asse7);
            }
            else
            {
                Console.WriteLine("  10- " + asse8 + "    20- " + asse9 + "     18- " + asse7);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("               31- " + asse10);
            Console.ReadLine();
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(nom + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + nom + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + nom + "[...]");
                        if (mouvant > 6)
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            int buteur = 0;
            int x = 0;
            int y = 0;
            string name = " ";
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            if (type_m == 1)
            {
                while (y < exterieur)
                {
                    y = y + 1;
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = asse1;
                    }
                    if (buteur == 2)
                    {
                        name = asse2;
                    }
                    if (buteur == 3)
                    {
                        name = asse3;
                    }
                    if (buteur == 4)
                    {
                        name = asse4;
                    }
                    if (buteur == 5)
                    {
                        name = asse5;
                    }
                    if (buteur == 6)
                    {
                        name = asse6;
                    }
                    if (buteur == 7)
                    {
                        name = asse7;
                    }
                    if (buteur == 8)
                    {
                        name = asse8;
                    }
                    if (buteur == 9)
                    {
                        name = asse9;
                    }
                    if (buteur == 10)
                    {
                        name = asse10;
                    }
                    if (buteur == 11)
                    {
                        name = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 1)
                {
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = asse1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asse2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asse3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asse4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asse5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asse6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asse10;
                    }
                    y = 0;
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asse10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("CHANGEMENT ASSE (1/3)");
            Console.ReadLine();
            Console.Clear();
            if (composition == 0)
            {
                Console.WriteLine("CHANGEMENT ASSE (1/3)");
                Console.WriteLine("< 10 KHAZRI");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("CHANGEMENT ASSE (1/3)");
                Console.WriteLine("< 10 KHAZRI");
                Console.WriteLine("> 14 HONORAT");
                asse8 = "HONORAT";
            }
            else
            {
                Console.WriteLine("CHANGEMENT ASSE (1/3)");
                Console.WriteLine("< 14 HONORAT");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("CHANGEMENT ASSE (1/3)");
                Console.WriteLine("< 14 HONORAT");
                Console.WriteLine("> 10 KHAZRI");
                asse8 = "KHAZRI";
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + x + "          " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            if (type_m == 1)
            {
                int carton_rouge;
                if (domicile != 2)
                {
                    carton_rouge = new Random().Next(1, 6);
                }
                else
                {
                    carton_rouge = new Random().Next(1, 5);
                }
                if (carton_rouge == 1)
                {
                    if (domicile > 0)
                    {
                        domicile = domicile - 1;
                    }
                    int red_card = new Random().Next(1, 4);
                    if (red_card == 1)
                    {
                        Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                        Console.WriteLine("  " + asse9);
                        asse9 = "ABI";
                        asse9bis = "NORDIN (P)";
                    }
                    if (red_card > 1)
                    {
                        if (composition == 1)
                        {
                            Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                            Console.WriteLine("  " + asse8);
                            asse8 = "BOUANGA";
                            asse9 = "ABI";
                            asse10 = "ABI";
                        }
                        else
                        {
                            Console.WriteLine("CARTON ROUGE - A.S.S.E       ");
                            Console.WriteLine("  " + asse9);
                            asse9 = "ABI";
                            asse9bis = "NORDIN (P)";
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = asse1;
                    }
                    if (buteur == 2)
                    {
                        name = asse2;
                    }
                    if (buteur == 3)
                    {
                        name = asse3;
                    }
                    if (buteur == 4)
                    {
                        name = asse4;
                    }
                    if (buteur == 5)
                    {
                        name = asse5;
                    }
                    if (buteur == 6)
                    {
                        name = asse6;
                    }
                    if (buteur == 7)
                    {
                        name = asse7;
                    }
                    if (buteur == 8)
                    {
                        name = asse8;
                    }
                    if (buteur == 9)
                    {
                        name = asse9;
                    }
                    if (buteur == 10)
                    {
                        name = asse10;
                    }
                    if (buteur == 11)
                    {
                        name = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 1)
                {
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = asse1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asse2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asse3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asse4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asse5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asse6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asse10;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = asse7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asse8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asse9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asse10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asse9bis;
                    }
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 1;
                while (y < exterieur)
                {
                    Console.WriteLine(" A.S.S.E       " + Equipe);
                    Console.WriteLine("     " + x + "          " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                }
            }
            Console.WriteLine(" A.S.S.E       " + Equipe);
            Console.WriteLine("     " + domicile + "          " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
        }

        static void AffichageASM(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            Console.WriteLine("COMPOSITION AS MONACO FC (4-2-3-1)");
            int composition = new Random().Next(0, 2);
            int choix_d = new Random().Next(0, 2);
            string asm1 = "BOLLO-TOURE";
            string asm2 = "PAVLOVIC";
            string asm3 = "HENRICHS";
            string asm4 = "SIDIBE";
            string asm5 = "N'DORAM";
            string asm6 = "AHOULOU";
            string asm7 = "BALDE";
            string asm8 = "GOLOVIN";
            string asm9 = "GEUBBELS";
            string asm10 = "BEN YEDDER";
            string asm10bis = "BEN YEDDER (P)";
            Console.WriteLine(" ");
            Console.WriteLine("             40-LECOMPTE");
            Console.ReadLine();
            Console.WriteLine(" ");
            if (choix_d==0)
            {
                asm4 = "AGUILAR";
                Console.WriteLine("12- " + asm4 + "  6- " + asm3 + "   - " + asm2 + "  13- " + asm1);
            }
            else
            {
                Console.WriteLine("  - " + asm4 + "  6- " + asm3 + "   - " + asm2 + "  13- " + asm1);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("       - " + asm6 + "               35- " + asm5);
            Console.ReadLine();
            Console.WriteLine(" ");
            if (composition == 1)
            {
                asm9 = "DIOP";
                Console.WriteLine("  17- " + asm8 + "       - " + asm9 + "      14- " + asm7);
            }
            else
            {
                Console.WriteLine("  10- " + asm8 + "    20- " + asm9 + "     18- " + asm7);
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("                9- " + asm10);
            Console.ReadLine();
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.WriteLine(" ");
                Console.Write(nom + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + nom + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + nom + "[...]");
                        if (mouvant > 6)
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            int buteur = 0;
            int x = 0;
            int y = 0;
            string name = " ";
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            0");
            Console.ReadLine();
            Console.Clear();
            int type_m = new Random().Next(1, 3);
            if (type_m == 1)
            {
                while (y < exterieur)
                {
                    y = y + 1;
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 0;
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = asm1;
                    }
                    if (buteur == 2)
                    {
                        name = asm2;
                    }
                    if (buteur == 3)
                    {
                        name = asm3;
                    }
                    if (buteur == 4)
                    {
                        name = asm4;
                    }
                    if (buteur == 5)
                    {
                        name = asm5;
                    }
                    if (buteur == 6)
                    {
                        name = asm6;
                    }
                    if (buteur == 7)
                    {
                        name = asm7;
                    }
                    if (buteur == 8)
                    {
                        name = asm8;
                    }
                    if (buteur == 9)
                    {
                        name = asm9;
                    }
                    if (buteur == 10)
                    {
                        name = asm10;
                    }
                    if (buteur == 11)
                    {
                        name = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 1)
                {
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = asm1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asm2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asm3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asm4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asm5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asm6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asm10;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asm10;
                    }
                    y = 0;
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asm10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("CHANGEMENT AS MONACO FC (1/3)");
            Console.ReadLine();
            Console.Clear();
            if (composition == 0)
            {
                Console.WriteLine("CHANGEMENT AS MONACO FC (1/3)");
                Console.WriteLine("< 13 GEUBBELS");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("CHANGEMENT AS MONACO FC (1/3)");
                Console.WriteLine("< 13 GEUBBELS");
                Console.WriteLine(">    DIOP");
                asm9 = "DIOP";
            }
            else
            {
                Console.WriteLine("CHANGEMENT AS MONACO FC (1/3)");
                Console.WriteLine("<    DIOP");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("CHANGEMENT AS MONACO FC (1/3)");
                Console.WriteLine("<    DIOP");
                Console.WriteLine("> 13 GEUBBELS");
                asm9 = "GEUBBELS";
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + x + "            " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
            if (type_m == 1)
            {
                int carton_rouge;
                if (domicile != 2)
                {
                    carton_rouge = new Random().Next(1, 6);
                }
                else
                {
                    carton_rouge = new Random().Next(1, 5);
                }
                if (carton_rouge == 1)
                {
                    if (domicile > 0)
                    {
                        domicile = domicile - 1;
                    }
                    int red_card = new Random().Next(1, 4);
                    if (red_card == 1)
                    {
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm8);
                        asm8 = "BEN YEDDER";
                    }
                    if (red_card == 2)
                    {
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm8);
                        asm9 = "BEN YEDDER";
                    }
                    if (red_card == 3)
                    {
                        Console.WriteLine("CARTON ROUGE - AS MONACO FC       ");
                        Console.WriteLine("  " + asm10);
                        asm10 = "BALDE";
                        asm10bis = "GOLOVIN (P)";
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 0)
                {
                    x = 1;
                    buteur = new Random().Next(1, 12);
                    if (buteur == 1)
                    {
                        name = asm1;
                    }
                    if (buteur == 2)
                    {
                        name = asm2;
                    }
                    if (buteur == 3)
                    {
                        name = asm3;
                    }
                    if (buteur == 4)
                    {
                        name = asm4;
                    }
                    if (buteur == 5)
                    {
                        name = asm5;
                    }
                    if (buteur == 6)
                    {
                        name = asm6;
                    }
                    if (buteur == 7)
                    {
                        name = asm7;
                    }
                    if (buteur == 8)
                    {
                        name = asm8;
                    }
                    if (buteur == 9)
                    {
                        name = asm9;
                    }
                    if (buteur == 10)
                    {
                        name = asm10;
                    }
                    if (buteur == 11)
                    {
                        name = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 1)
                {
                    buteur = new Random().Next(1, 11);
                    x = 2;
                    if (buteur == 1)
                    {
                        name2 = asm1;
                    }
                    if (buteur == 2)
                    {
                        name2 = asm2;
                    }
                    if (buteur == 3)
                    {
                        name2 = asm3;
                    }
                    if (buteur == 4)
                    {
                        name2 = asm4;
                    }
                    if (buteur == 5)
                    {
                        name2 = asm5;
                    }
                    if (buteur == 6)
                    {
                        name2 = asm6;
                    }
                    if (buteur == 7)
                    {
                        name2 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name2 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name2 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name2 = asm10;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 2)
                {
                    buteur = new Random().Next(7, 11);
                    x = 3;
                    if (buteur == 7)
                    {
                        name3 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name3 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name3 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name3 = asm10;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (domicile > 3)
                {
                    buteur = new Random().Next(7, 12);
                    x = 4;
                    if (buteur == 7)
                    {
                        name4 = asm7;
                    }
                    if (buteur == 8)
                    {
                        name4 = asm8;
                    }
                    if (buteur == 9)
                    {
                        name4 = asm9;
                    }
                    if (buteur == 10)
                    {
                        name4 = asm10;
                    }
                    if (buteur == 11)
                    {
                        name4 = asm10bis;
                    }
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + exterieur);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                y = 1;
                while (y < exterieur)
                {
                    Console.WriteLine(" AS MONACO FC       " + Equipe);
                    Console.WriteLine("        " + x + "            " + y);
                    Console.WriteLine(" ");
                    Console.WriteLine(name);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    Console.WriteLine(name4);
                    Console.ReadLine();
                    Console.Clear();
                    y = y + 1;
                }
            }
            Console.WriteLine(" AS MONACO FC       " + Equipe);
            Console.WriteLine("        " + domicile + "            " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
        }

        static void AffichageMHSC(int domicile, string nom, int mouvant, string Equipe, int pts, int exterieur, int spectateur)
        {
            Console.Clear();
            if (nom != " ")
            {
                Console.WriteLine("1- TITULAIRE ");
                Console.WriteLine("2- REMPLACANT");
                Console.Write(nom + " : ");
                string titulaire = (Console.ReadLine());
                Console.Clear();
                switch (titulaire)
                {
                    case "1":
                        Console.WriteLine("[...]TITULAIRE : " + nom + "[...]");
                        break;
                    default:
                        Console.WriteLine("[...]REMPLACANT : " + nom + "[...]");
                        if (mouvant > 3)
                        {
                            pts = pts - 1;
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("COMPOSITION MONTPELLIER HERAULT SC (3-4-1-2)");
            string mhsc1 = "SOUQUET";
            string mhsc2 = "COZZA";
            string mhsc3 = "OYONGO";
            string mhsc4 = "SUAREZ";
            string mhsc5 = "SAVANIER";
            string mhsc6 = "LE TALLEC";
            string mhsc7 = "FERRI";
            string mhsc8 = "MOLLET";
            string mhsc9 = "DELORT";
            string mhsc10 = "LABORDE";
            string mhsc9bis = "DELORT (P)";
            Console.WriteLine(" ");
            Console.WriteLine("             16-BERTAUD");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("  2- " + mhsc1 + "   31- " + mhsc2 + "   8- " + mhsc3);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("24- " + mhsc4 + " 11- " + mhsc5 + " 14- " + mhsc6 + " 12- " + mhsc7);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("               25- " + mhsc8);
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("     9- " + mhsc9 + "             10- " + mhsc10);
            Console.ReadLine();
            Console.Clear();
            int buteur = 0;
            int x = 0;
            int y = 1;
            string name = " ";
            string name2 = " ";
            string name3 = " ";
            string name4 = " ";
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              0");
            Console.ReadLine();
            Console.Clear();
            while (y < exterieur)
            {
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + y);
                Console.ReadLine();
                Console.Clear();
                y = y + 1;
            }
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              " + exterieur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("AFFLUENCE : " + spectateur);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + x + "              " + exterieur);
            Console.ReadLine();
            Console.Clear();
            if (domicile > 0)
            {
                x = 1;
                buteur = new Random().Next(1, 12);
                if (buteur == 1)
                {
                    name = mhsc1;
                }
                if (buteur == 2)
                {
                    name = mhsc2;
                }
                if (buteur == 3)
                {
                    name = mhsc3;
                }
                if (buteur == 4)
                {
                    name = mhsc4;
                }
                if (buteur == 5)
                {
                    name = mhsc5;
                }
                if (buteur == 6)
                {
                    name = mhsc6;
                }
                if (buteur == 7)
                {
                    name = mhsc7;
                }
                if (buteur == 8)
                {
                    name = mhsc8;
                }
                if (buteur == 9)
                {
                    name = mhsc9;
                }
                if (buteur == 10)
                {
                    name = mhsc10;
                }
                if (buteur == 11)
                {
                    name = mhsc9bis;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 1)
            {
                buteur = new Random().Next(1, 11);
                x = 2;
                if (buteur == 1)
                {
                    name2 = mhsc1;
                }
                if (buteur == 2)
                {
                    name2 = mhsc2;
                }
                if (buteur == 3)
                {
                    name2 = mhsc3;
                }
                if (buteur == 4)
                {
                    name2 = mhsc4;
                }
                if (buteur == 5)
                {
                    name2 = mhsc5;
                }
                if (buteur == 6)
                {
                    name2 = mhsc6;
                }
                if (buteur == 7)
                {
                    name2 = mhsc7;
                }
                if (buteur == 8)
                {
                    name2 = mhsc8;
                }
                if (buteur == 9)
                {
                    name2 = mhsc9;
                }
                if (buteur == 10)
                {
                    name2 = mhsc10;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 2)
            {
                buteur = new Random().Next(8, 11);
                x = 3;
                if (buteur == 8)
                {
                    name3 = mhsc8;
                }
                if (buteur == 9)
                {
                    name3 = mhsc9;
                }
                if (buteur == 10)
                {
                    name3 = mhsc10;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.ReadLine();
                Console.Clear();
            }
            if (domicile > 3)
            {
                buteur = new Random().Next(8, 12);
                x = 4;
                if (buteur == 8)
                {
                    name4 = mhsc8;
                }
                if (buteur == 9)
                {
                    name4 = mhsc9;
                }
                if (buteur == 10)
                {
                    name4 = mhsc10;
                }
                if (buteur == 11)
                {
                    name4 = mhsc9bis;
                }
                Console.WriteLine("MONTPELLIER        " + Equipe);
                Console.WriteLine("     " + x + "              " + exterieur);
                Console.WriteLine(" ");
                Console.WriteLine(name);
                Console.WriteLine(name2);
                Console.WriteLine(name3);
                Console.WriteLine(name4);
                Console.Clear();
            }
            Console.WriteLine("MONTPELLIER        " + Equipe);
            Console.WriteLine("     " + domicile + "              " + exterieur);
            Console.WriteLine(" ");
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
            Console.ReadLine();
            Console.Clear();
        }

        static void AffichageTdC(int domicile, string Equipe, int exterieur, int spectateur, string Equipe_avant, string qualification, int tab, string Equipe_avant2, string qualification2)
        {
            int cas = 0;
            while (Equipe == qualification & Equipe == Equipe_avant || qualification2 == Equipe_avant2)
            {
                int nba = new Random().Next(1, 4);
                if (nba == 1)
                {
                    Equipe_avant = "OL";
                    Equipe_avant2 = "   OL  ";
                }
                if (nba == 2)
                {
                    Equipe_avant = "AS MONACO FC";
                    Equipe_avant2 = " MONACO";
                }
                if (nba == 3)
                {
                    Equipe_avant = "PARIS SAINT-GERMAIN";
                    Equipe_avant2 = "  PSG  ";
                }
            }
            if (Equipe == qualification)
            {
                cas = 2;
            }
            else
            {
                cas = 1;
            }
            Console.WriteLine("TROPHEE DES CHAMPIONS : ");
            Console.WriteLine("LIEU : STADE DE FRANCE A SAINT-DENIS (93200)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("REPRSENTANT DE LA COUPE DE FRANCE : " + qualification);
            Console.WriteLine("REPRSENTANT DE LA LIGUE 1 Conforama : " + Equipe_avant);
            int x = 0;
            int y = 0;
            Console.ReadLine();
            Console.Clear();
            if (cas == 2)
            {
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                int type_m = new Random().Next(1, 3);
                if (type_m == 1)
                {
                    while (y < exterieur)
                    {
                        y = y + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    while (x < domicile)
                    {
                        x = x + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("AFFLUENCE : " + spectateur);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                if (type_m == 1)
                {
                    while (x < domicile)
                    {
                        x = x + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    while (y < exterieur)
                    {
                        y = y + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                if (exterieur == domicile)
                {
                    Console.WriteLine("TIRS AU BUTS DU TROPHEE DES CHAMPIONS");
                    Console.ReadLine();
                    Console.Clear();
                    if (tab == 1)
                    {
                        Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe + " (TAB)");
                    }
                    else
                    {
                        Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                    }
                }
                if (exterieur > domicile)
                {
                    Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                if (domicile > exterieur)
                {
                    Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                int type_m = new Random().Next(1, 3);
                if (type_m == 1)
                {
                    while (y < exterieur)
                    {
                        y = y + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    while (x < domicile)
                    {
                        x = x + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("AFFLUENCE : " + spectateur);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.WriteLine(" ");
                Console.ReadLine();
                Console.Clear();
                if (type_m == 1)
                {
                    while (x < domicile)
                    {
                        x = x + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    while (y < exterieur)
                    {
                        y = y + 1;
                        Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                        Console.WriteLine("   " + x + "         " + y);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine(qualification2 + "   " + Equipe_avant2);
                Console.WriteLine("   " + x + "         " + y);
                Console.ReadLine();
                Console.Clear();
                if (exterieur == domicile)
                {
                    Console.WriteLine("TIRS AU BUTS DU TROPHEE DES CHAMPIONS");
                    Console.ReadLine();
                    Console.Clear();
                    if (tab == 1)
                    {
                        Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe + "(TAB)");
                    }
                    else
                    {
                        Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                    }
                }
                if (domicile > exterieur)
                {
                    Console.WriteLine("FINALISTE DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                if (exterieur > domicile)
                {
                    Console.WriteLine("VAINQUEUR DU TROPHEE DES CHAMPIONS : " + Equipe);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Credit()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(V.8.51 - 02/02/2020 18:01)");//Crédit de fin de programme
        }
    }
}
