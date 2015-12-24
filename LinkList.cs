using System;
using System.Collections.Generic;

/*

    meerdere lijnen commentaar
*/

    //1 lijnt comentaar


namespace Hybrid_SaaS
{
    public enum Link
    {
        //Menu opties
        MenuHome,
        MenuPakketten,
        MenuModules,
        MenuOver,
        MenuSupport,
        MenuContact,


        
        Abonnementen,
        Administratie,
        AlgemeneVoorwaarden,
        AlgemeneVoorwaardenPdf,
        Alles,
        BalansWinstVerliesrekening,
        Bankrekening,
        Bedrijfsagenda,
        BrowserDownload,
        Certificatenbeheer,
        Commisie,
        Commissiebeheer,
        Contractenbeheer,
        Crm,
        Dataopslag,
        Download,
        Email,
        ExportBoekhouding,
        ExportExcel,
        ExportExternPakket,
        Extranet,
        Facebook,
        Factsheet,
        Facturatie,
        FacturatieDebiteurbeheer,
        Financieel,
        Gebouwbeheer,
        GebruikerExtern,
        GebruikerIntern,
        GooglePlus,
        Handleiding,
        HelpDesk,
        Hrm,
        InkoopfacturatieCrediteurenbeheer,
        Inkooporderbeheer,
        Inventarisbeheer,
        InvoerTicket,
        KijkMetMijMee,
        KmRegistratie,
        LicentieVoorwaardenPdf,
        Meerwerk,
        MeestGesteldeVragen,
        Notities,
        OffertesOrders,
        OutlookAddDownload,
        OutlookAddIn,
        Overig,
        PakketAanvullendFinancieel,
        PakketContractbeheer,
        PakketErp,
        PakketKwaliteitsControle,
        PakketKwaliteitsControleTickets,
        PakketOfferteVoorraad,
        PakketTicketsFacturatie,
        Prepaidkaarten,
        Productenbeheer,
        Prognosebeheer,
        Projectbeheer,
        Relatiebeheer,
        ReleaseNotes,
        SiteMap,
        Termijnstatenbeheer,
        TicketSysteem,
        Tijdregistratie,
        Twitter,
        Voorraadbeheer,
        VragenlijstenEquettes,
        Wachtwoordbeheer,
        Webshop,
        Werkbonnen,
        WordAddDownload,
        Youtube,
        Prijzenlijst,
        PakketCommisiebeheer,
        Consultancy,
        Correspondentie,
        Onderaannemer,
        Voortgang,
        Inkoopbeheer,
        DataAdapter,
        prijzenlijstpakkettenPdf,
        prijzenlijstmodulesPdf,
        prijzenlijstimplementatiePdf,
        Quote,
        DescriptionRight,
        Additional,
        FotoAdapter,


    }

    public enum LinkType
    {
        Page,
        Module
    }


    public static class LinkList
    { 
        public class LinkInfo
        {
            public LinkType Type = LinkType.Page;

            public string Name;
            public string LinkName = "";

            public string Url = "#";
            
            public string IntroText = "";

            //indien pagetitle leeg is, valt deze terug naar introtext
            public string PageTitle;
            public string Description = "";
            public string DescriptionRight = "";

            public string Image = "";
            public string ImageBig = "";

            public string Price = "";

            public string Quote = "";

            public string MetaKeywords = "";
            public string Additional = "";

            public bool OpenInNewWindow
            {
                get;
                set;
            }

            public List<ManualItem> ManualItems = new List<ManualItem>();
            public List<string> FactSheet = new List<string>();
            public List<PhotoItem> PhotoItems = new List<PhotoItem>();
        }



        /// <summary>
        /// Foto items (links / rechts)
        /// </summary>
        public class PhotoItem
        {
            public string Image
            {
                get;
                set;
            }

            public string Title
            {
                get;
                set;
            }

            public string Description
            {
                get;
                set;
            }
        }


        /// <summary>
        /// Handleiding links
        /// </summary>
        public class ManualItem
        {
            public string Name
            {
                get;
                set;
            }

            public string Link
            {
                get;
                set;
            }
        }



        public static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();
        public static Dictionary<string, LinkInfo> UrlDictionary = new Dictionary<string, LinkInfo>(StringComparer.InvariantCultureIgnoreCase);

        public static string GetLink(Link link)
        {
            return LinkDictionary[link].Url;
        }
        public static string GetTitle(Link link)
        {
            return LinkDictionary[link].IntroText;
        }
        public static string GetDescription(Link link)
        {
            return LinkDictionary[link].Description;
        }
        public static string GetDescriptionRight(Link link)
        {
            return LinkDictionary[link].DescriptionRight;
        }
        public static string GetImage(Link link)
        {
            return LinkDictionary[link].Image;
        }
        public static string GetPrice(Link link)
        {
            return LinkDictionary[link].Price;
        }
        public static string GetLinkName(Link link)
        {
            return LinkDictionary[link].LinkName;
        }
        public static string GetBigImages(Link link)
        {
            return LinkDictionary[link].ImageBig;
        }
        public static string GetQuote(Link link)
        {
            return LinkDictionary[link].Quote;
        }
        public static string GetAdditional(Link link)
        {
            return LinkDictionary[link].Additional;
        }


        static LinkList()
        {

            //modules

            LinkDictionary[Link.MenuModules] = new LinkInfo
            {
                Name = "Modules",
                Url = "/modules",

                IntroText = "Ga naar de module-overzichts pagina",
                PageTitle = "Module overzicht",
                Quote = "Vul je basispakket aan met onderstaande modules om zo de beste workflow te realiseren voor je bedrijf",
                Price = "Vanaf € 30,- per maand",
                LinkName = "Modules",
                Image = "/images/module_iconen/module-45.png",
                ImageBig = "/images/module_iconen/module-90.png",
                MetaKeywords = "",
                FactSheet = new List<string>
                {
                    "bla bla bla",
                    "bla bla bla",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = ".",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = ".",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = ".",
                        Link = "."
                    }
                }
            };
            LinkDictionary[Link.Abonnementen] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Abonnementen",
                Url = "/Module/Abonnementen",
                IntroText = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Description = "De module Hybrid SaaS Abonnementenbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar. Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige abonnementen. Met Hybrid SaaS Abonnementenbeheer loop je nooit meer achter de feiten aan.",
                Image = "/images/module_iconen/abbonnement-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Abonnementen",
                ImageBig = "/images/module_iconen/abbonnement-90.png",
                MetaKeywords = "Inkoopcontracten, Contributie, Maandabonnementen, Overeenstemming, Huurcontract, Telefoonabonnement",

                FactSheet = new List<string>
                {
                    "Abonnement type ingeven",
                    "Abonnement koppelen aan bedrijven",
                    "Abonnement koppelen aan medewerkers",
                    "Abonnement koppelen aan contract",
                    "Abonnement nummer ingeven",
                    "Een omschrijving van het abonnement ingeven",
                    "Start- en einddatum ingeven",
                    "Herinneringsdatum ingeven (met herinneringsfunctie voor als er een contract verleng moet worden of stopt)",
                    "De frequentie van het contract aangeven met het daarbij behorende bedrag ",
                    "Een opmerking kunnen toevoegen voor intern gebruik",
                    "Digitale kopie toevoegen",
                    "Overzicht geldige en lopende Abonnement",
                    "Overzicht te vernieuwen Abonnement",
                    "Overzicht verlopen Abonnement",
                    "Overzichten exporten naar Microsoft Excel",
                    "Digitaal document opstellen",
                    "Digitale kopie verzenden",
                    "Vaste lasten registreren en koppelen aan inkoopfacturen",

                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/abonnement1.jpg",
                        Title = "Helder overzicht van al je lopende inkoopcontracten en abonnementen",
                        Description = "Zie in 1 oogopslag al je lopende abonnement en inkoopcontracten bij je leveranciers al je getekenden contracten sla je digitaal op zodat je deze altijd en overal kan raadplegen",
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/abonnement2.jpg",
                        Title = "Automatische meldingen als er contracten aflopen",
                        Description = "Nooit meer onnodig te veel betalen voor contracten die je ben vergeten op te zeggen wij sturen dagelijks een overzicht met al je te vernieuwde of te beëindigen contracten in dien je contracten inkoopt welke je doorbelast krijg je automatisch een notificatie wanneer je een verkoopcontract beëindigt  op deze manier  heb je altijd een overzicht in je inkoop van je verkoop contracten.",
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/abonnement1.jpg",
                        Title = "Meer inzicht in je cashflow",
                        Description = "Door het goed vast leggen van al je inkoopcontracten geven wij inzicht in je aankomende vaste lasten. Op die manier krijg j een actueel overzicht in je cashflow zodat je geen liquiditeit problemen aantreft.",
                    },
                },
            };

            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Bankrekening",
                Url = "/Module/bankrekening",
                IntroText = "De module Bankrekeningen schept orde in de chaos. U kan eenvoudig banktransacties importeren en afletteren waardoor u altijd inzicht heeft in de openstaande en betaalde facturen.",
                Description = " Lees de banktransacties in en koppel ze eenvoudig aan openstaande verkoopfacturen. Het is ook mogelijk om incassobatches aan te maken. Het inlezen van banktransacties is ook handig voor de verwerking van inkoopfacturen. Zo kun je afschrijvingen direct koppelen aan de grootboekrekening of gegevens van inkoopfacturen automatisch gebruiken voor betalingen en incasso's.",
                Image = "/images/module_iconen/bank-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Bankrekening",
                ImageBig = "/images/module_iconen/bank-90.png",

                FactSheet = new List<string>
                {
                    "Meerdere bankrekeningen vastleggen (per entiteit)",
                    "Betaalmethodes definiëren vastleggen",
                    "Banktransacties importeren MT940 (ABN, Rabo Bank, ING BANK, Deutsche Bank)",
                    "Inkoopfacturen exporteren en betalen door middel van CLIEOP bestanden",
                    "Betalingen automatisch incasseren door middel van CLIEOP bestanden",
                    "Bankrekeningen koppelen aan bedrijven, personen en medewerkers",
                    "Betalingsstamgegevens vastleggen",
                    "Overzichten exporten naar Microsoft  Excel",
                    "Transacties koppelen aan een bedrijf",
                    "Transacties koppelen aan een persoon",
                    "Transacties koppelen aan een medewerker",
                    "Transacties koppelen aan verkoopfactuur",
                    "Transacties koppelen aan een inkoopfactuur",
                    "Transacties koppelen aan een boekstuknummer",
                    "Transacties koppelen aan een grootboekrekening",
                    "Opmerkingen vastleggen bij een transactie",
                    "Handmatig transacties aanmaken",
                    "Digitale kopie toevoegen",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/bankrekening1.jpg",
                        Title = "Bankrekening",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/bankrekening2.jpg",
                        Title = "Bankrekening",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Automatische incasso limieten instellen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/bankrekening/limiet-instellen/limiet-instellen"
                    },
                    new ManualItem
                    {
                        Name = "Verwijderen van de bankrekeningimport",
                        Link = "http://hybridsaas.support/pages/support-site/modules/bankrekening/import-verwijderen/import-verwijderen"
                    },
                    new ManualItem
                    {
                        Name = "Btw aanpassen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/balans-winst-verliesrekening/BTW-aanpassen/BTW-aanpassen"
                    },
                    new ManualItem
                    {
                        Name = "Banktransacties importeren (MT940)",
                        Link = "http://hybridsaas.support/pages/support-site/modules/bankrekening/importeren-mt940/banktransacties-importeren-mt940"
                    },
                    new ManualItem
                    {
                        Name = "De kas als bankrekening aanmaken",
                        Link = "http://hybridsaas.support/pages/support-site/modules/bankrekening/kas-als-bankrekening/de-kas-als-bankrekening-aanmaken"
                    }
                }
            };

            LinkDictionary[Link.BalansWinstVerliesrekening] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Balans Winst & Verliesrekening",
                Url = "/Module/balans-winst-verliesrekening",
                IntroText = "De balans & winsten verliesrekening is een kasstroomoverzicht en daarmee een onderdeel van een jaarrekening. De balans & winst en verliesrekening geeft een overzicht van de kosten en opbrengsten van de entiteit over een bepaalde periode (meestal een jaar). ",
                Description = "Het saldo van de balans & winst en verliesrekening is de over de periode behaalde winst of het over de periode geleden verlies. In dit artikel wordt het proces om een balans & winst en verliesrekening op te maken beschreven. Voordat u een Balans & Winst en verliesrekening kunt opmaken dient u eerst de basis inrichting uit te voeren.",
                Image = "/images/module_iconen/balanswinst-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Balans Winst & Verliesrekening",
                ImageBig = "/images/module_iconen/balanswinst-90.png",

                FactSheet = new List<string>
                {
                    "Winst- en verlies rekening opstellen",
                    "Balans opstellen",
                    "Memoriaal boekingen aanmaken en inzien",
                    "Zoeken op grootboekrekeningnummers",
                    "Overzichten afdrukken",
                    "Overzicht exporten naar Microsoft Excel",
                    "Verkoop facturen exporteren naar ander boekhoudsysteem (Exact Online, Exact Globe, Accountview)",
                    "Inkoop facturen exporteren naar ander boekhoudsysteem (Exact Online, Exact Globe, Accountview)",
                    "Verkoopboek inzien",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/balanswinstverlies1.jpg",
                        Title = "Balans Winst & Verliesrekening",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/balanswinstverlies2.jpg",
                        Title = "Balans Winst & Verliesrekening",
                        Description = "."
                    }
                },
            };

            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Bedrijfsagenda",
                Url = "/Module/bedrijfsagenda",
                IntroText = "Met de bedrijfsagenda kan je heel eenvoudig het rooster van je medewerkers  bijhouden, je kan in één opslag zien hoeveel uur een medewerkers nog heeft staan of al heeft opgenomen. ",
                Description = "Vanuit de bedrijfsagenda kan je makkelijk een ticket aanmaken en inplannen, een verlof aanvragen of een bedrijfsgebeurtenis aanmaken. Je kan per medewerkers  ook een Microsoft Export naar excel maken zodat je makkelijk kunt zien wanneer er vrij is genomen of ziek is geweest.",
                Image = "/images/module_iconen/bedrijfsagenda-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Bedrijfsagenda",
                ImageBig = "/images/module_iconen/bedrijfsagenda-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/bedrijfagenda1.jpg",
                        Title = "Bedrijfsagenda",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/bedrijfagenda2.jpg",
                        Title = "Bedrijfsagenda",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Certificatenbeheer",
                Url = "/Module/certificatenbeheer",
                IntroText = "Eenvoudig kunnen zien wanneer een het rijbewijs of paspoort verloopt van je personeel verloopt? Hybrid SaaS maakt het mogelijk! ",
                Description = "De module Certificatenbeheer schept orde in de chaos en plaatst alle certificaten overzichtelijk bij elkaar. Wanneer een certificaat tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Zodat je gegevens altijd op orde zijn.",
                Image = "/images/module_iconen/certificaten-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Certificatenbeheer",
                ImageBig = "/images/module_iconen/certificaten-90.png",

                FactSheet = new List<string>
                {
                    "Certificaat type ingeven",
                    "Certificaat gegevens vastleggen ",
                    "Certificaat type ingeven",
                    "Certificaat gegevens vastleggen",
                    "Certificaten koppelen aan bedrijven",
                    "Certificaten koppelen aan medewerkers",
                    "Certificaat nummer ingeven",
                    "Start- en einddatum ingeven",
                    "Herinneringsdatum ingeven (met herinneringsfunctie)",
                    "Digitale kopie opslaan",
                    "Overzicht geldige en lopende Certificaten",
                    "Overzicht te vernieuwen Certificaten",
                    "Overzicht verlopen Certificaten",
                    "Overzichten exporten naar Microsoft Excel",
                    "Digitaal document opstellen",
                    "Digitale kopie verzenden",
                    "Opmerking ingeven",
                    "Vaste lasten registreren en koppelen aan inkoopfacturen",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/certificaten1.jpg",
                        Title = "Certificatenbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/certificaten2.jpg",
                        Title = "Certificatenbeheer",
                        Description = "."
                    }
                },
            };

            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Commissiebeheer",
                Url = "/Module/Commissiebeheer",
                Quote = "Werk je met resellers? Dan is Commissiebeheer van Hybrid SaaS zeker interessant voor jouw organisatie. ",
                IntroText = "Werk je met resellers? Dan is Commissiebeheer van Hybrid SaaS zeker interessant voor jouw organisatie. ",
                Description = "Met Commissiebeheer zorg je ervoor dat de registraties en betalingen van provisies altijd op orde zijn. Voor iedere factuur die jij verstuurt rekenen wij uit hoeveel commissie je af dient te dragen aan wederverkopers, resellers of agenten. Of je nu werkt met Tickets & Facturatie, Contractbeheer of Offerte & Voorraad, Commissiebeheer sluit naadloos aan bij al deze pakketten.",
                Image = "/images/module_iconen/commissiebeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Commissiebeheer",
                ImageBig = "/images/module_iconen/commissiebeheer-90.png",
                MetaKeywords = "Courtage, Provisie, Wedeverkoper, Beloning, Kickback fee, Commissie, Commissieafspraken, Commissiebedragen",
                

                FactSheet = new List<string>
                {
                    "Commissie ontvangende partij vast leggen, als bedrijf of als (intern)accountmanager",
                    "Start- en einddatum vastleggen voor de commissieperiode",
                    "Commissietype vast leggen",
                    "Commissieafspraak aan een grootboekrekening koppelen",
                    "Commissiepercentage vastleggen op 4 decimalen nauwkeurig",
                    "Extra (bonus)commissie vastleggen bij eerste verkoop",
                    "Eventuele korting procentueel verdelen over commissie ontvangende- partij en verkopende partij",
                    "Commissie uitkering uitstellen voor betaling tot dat factuur is voldaan door koper",
                    "Commissies kunnen gekoppeld worden aan een: Bedrijf, Extern pakket (API), Contract, Contractregel, Grootboekrekening (werkcode), Product, Project, Orderbron, Productgroep, Productsubgroep",
                    "Per commissie kan je een notitie en een bijlage vastleggen",
                    "Commissie vast leggen per Entiteit",
                    "Overzicht van alle commissie ontvangende partijen, met totaal van alle facturen, gemiddelde commissiepercentage, commissiebedrag en commissieperiode",
                    "Overzicht van alle facturen zonder commissie",
                    "Overzicht van alle facturen met commissie",
                    "Overzicht van alle facturen zonder commissieafspraak",
                    "Commissies afromen over een bepaald tijdvak",
                    "Overzicht van commissie per factuur(regel)",
                    "Commissies herberekenen per factuur",
                    "Commissies verwijderen per factuur(regel)",
                    "Commissieoverzicht (digitaal) versturen naar commissie ontvangende partij",
                    "Commissieoverzicht omzetten in inkoopfactuur",
                },
                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/commissie1.png",
                        Title = "Leg eenvoudig al je commissies afspraken eenvoudig vast",
                        Description = "Leg gemakkelijk commissieafspraken per vertegenwoordiger of reseller van je product vast. Of het nu gaat om maandelijkse of eenmalige kickback fee’s, start up kosten of annuleringskosten dit is mogelijk met Hybrid SaaS commissiebeheer. Verdeel eventuele kortingen en betaal nooit onnodig voordat de facturen aan jou zijn voldaan."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/commissie2.jpg",
                        Title = "Waar je ook commissie op wilt uitkeren Hybrid SaaS maakt het mogelijk",
                        Description = "Op vrij wel alles is het mogelijk om commissies vast te leggen, denk hierbij aan een Bedrijf, Contract, Contractregel, Grootboekrekening (werkcode), Product, Project, Orderbron, Productgroep, Productsubgroep. Het is zelf mogelijk om provisies uit een ander extern systeem te importeren."
                    },
                     new PhotoItem
                    {
                        Image = "/images/modules/commissie1.jpg",
                        Title = "Eenvoudig overzicht van al je commissies",
                        Description = "Vrijwel vanuit elke hoek kan je de commissies inzichtelijk maken of je nu vanuit de factuur of de relatie kijkt, je krijgt altijd een actueel overzicht van de aankomende en reeds betaalde courtages"
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/commissie2.jpg",
                        Title = "Commissie overzichten eenvoudig omzetten tot een inkoopfactuur",
                        Description = "Het uitkeren van je beloningen naar je resellers, doe je eenvoudig door digitaal een helder overzicht te sturen van alle commissies, met 1 druk op de knop zet je de commissiebedragen om naar een inkoopfactuur en lees je deze digitaal in bij je bank"
                    },
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Commissie toepassen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/commissiebeheer/commissie-toepassen"
                    }
                }
            };

            LinkDictionary[Link.Contractenbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Contractenbeheer",
                Url = "/Module/contractenbeheer",
                Quote = "Waarom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? ",
                IntroText = "Waarom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? Met Hybrid SaaS Contracten heb je nauwelijks omkijken naar je periodiek uitgaande facturen en bestellingen en zo verbeter je eenvoudig je positieve cashflow. ",
                Description = "Periodiek terugkerende bestellingen plaats je automatisch bij je leveranciers. Abonnementen van je klanten kunnen worden ingegeven, waarbij de factuur per ingegeven termijn wordt verstuurd. Verzend facturen en bestellingen direct via e-mail. Bestaande orders en facturen kunnen direct geautomatiseerd worden. Als ICT - dienstverlener heb je een oneindige hoeveelheid contracten lopen bij klanten en leveranciers.Inkoopcontracten voor de eigen organisatie, maar ook inkoopcontracten voor klanten die weer gekoppeld zijn aan verkoopcontracten tussen jouw organisatie en de klant.",
                Image = "/images/module_iconen/contractbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Contractenbeheer",
                Additional = "Contract- en abonnementenbeheer kan als volgt worden genoemd: Periodieke facturatie, abonnementen factureren, abonnementskosten factureren, Huurcontracten, telefoonabonnementen, service contracten, onderhoudscontracten, verzekeringen, managementfee’s, hosting, licenties, domeinnamen, contributies",
                ImageBig = "/images/module_iconen/contractbeheer-90.png",

                FactSheet = new List<string>
                {
                    "***Algemeen***",
                    "Contracten vastleggen bij entiteit",
                    "Kenmerk of type vastleggen",
                    "Leverancier vastleggen",
                    "Contract opmaken voor een organisatie (bedrijf)",
                    "Contract opmaken bij een persoon (particuliere klant)",
                    "Factuuradres vastleggen",
                    "Afleveradres vastleggen",
                    "Contract koppelen aan een eindklant (eindgebruiker)",
                    "Contract koppelen aan adres van eindklant",
                    "E-mailadres vastleggen",
                    "Afdeling vastleggen",
                    "T.a.v. vastleggen",
                    "Automatisch contractnummer laten genereren",
                    "Contractomschrijving ingeven",
                    "Externe referentie van de klant vastleggen (bijv. PO nummers)",
                    "Weergave in referentie vastleggen",
                    "Ingangsdatum contract vastleggen",
                    "Einddatum of expiratiedatum contract vastleggen",
                    "Herinneringsdatum vastleggen",
                    "Laatste verlengdatum vastleggen",
                    "Type uitvoer vastleggen (factuur of order)",
                    "Uitsteldatum vastleggen",
                    "Contract uitschakelen voor verwerken",
                    "Frequentie van verwerken en genereren bepalen (dag, week, maand, kwartaal, jaar)",
                    "Contract automatisch verlengen na einddatum",
                    "Ingangsdatum van eerste contractverwerking instellen",
                    "Aantal en interval van verwerkingen vastleggen",
                    "Einddatum van verwerken vastleggen",
                    "Facturatiemoment bepalen (vooraf of achteraf)",
                    "Betalingscondities vastleggen (automatische incasso, overmaking via bank)",
                    "Contractwaarde instellen (dag, week, maand, kwartaal, jaar)",
                    "Onderscheid maken in terugkerende en eenmalige kosten",
                    "Setup- en cancelkosten vastleggen",
                    "Planningsoverzicht van geplande facturen in de toekomst (datum, aantal, waarde en tijdsinterval)",
                    "Overzicht van de reeds opgemaakte facturen uit het contract (factuurnummer, datum, aantal, waarde en factuurperiode)",
                    "Gegenereerde facturen direct inzien",
                    "Automatisch commissies en provisies vastleggen (per contract en/of contractregel)",
                    "Digitale kopie of scan van getekend contract online opslaan",
                    "Online bestanden en contractbijlagen overzichtelijk opslaan",
                    "Opmerkingen toevoegen (intern en/ of extern)",
                    "Inkoopcontracten en abonnementen koppelen aan contract",
                    "Overzicht van alle gekoppelde inkoopcontracten en inkoopabonnementen ",
                    "Automatische melding en notificaties van te beëindigen inkoopcontracten",

                    "***Acties***",
                    "Contracten dupliceren",
                    "Contracten opmaken op basis van template of sjabloon",
                    "Overzichten exporten naar Microsoft Excel",
                    "Contracten digitaal verzenden per mail",
                    "Contracten direct uitprinten",
                    "Direct details van contract inzien",
                    "Direct factuurregels inzien",
                    "Direct facturenoverzicht per contract inzien",
                    "Contracten factureren per entiteit, type, organisatie of persoon, project",
                    "Contracten automatisch samenvoegen",
                    "Proefronde draaien van contracten en abonnementen",

                    "***Overzichten***",
                    "Overzicht actieve en lopende contracten",
                    "Overzicht aflopende contracten",
                    "Overzicht verlopen en afgesloten contracten",
                    "Overzicht externe contracten",
                    "Overzicht te verwerken contracten",
                    "Historie van acties per contract",

                    "***Contract- en factuurregels***",
                    "Meerdere contractregels tegelijkertijd beëindigingen of verwijderen",
                    "Afzonderlijke contract- en factuurregels aan grootboekrekening koppelen",
                    "Afzonderlijke contract- en factuurregels aan btw code en percentage koppelen",
                    "Afzonderlijke contract- en factuurregels aan kostenplaats koppelen",
                    "Afzonderlijke contract- en factuurregelsS aan prepaidkaarten koppelen",
                    "Afzonderlijke contract- en factuurregels aan product uit productcatalogus koppelen",
                    "Afzonderlijke contract- en factuurregels aan prognoseproduct uit productcatalogus koppelen voor forecast",
                    "(Afwijkende) omschrijving contract- en factuurregels vastleggen",
                    "Aantal vastleggen (geconsolideerd of opgebouwd uit losse regels)",
                    "Eenheid bepalen (bijv. stuks, uur, m²)",
                    "Basisprijs (inclusief of exclusief BTW) vastleggen",
                    "Marge/ korting vastleggen",
                    "Totaalbedrag contract- en factuurregels (inclusief of exclusief BTW)",
                    "Totaalbedrag BTW contract- en factuurregels",
                    "Inkoopprijs per contract- en factuurregels vastleggen",
                    "Type contract- en factuurregel vastleggen (opstartkosten of annuleringskosten)",
                    "Contract- en factuurregels uitsluiten voor commissie",

                    "***Details contract- en factuurregels***",
                    "Variabele looptijden en eigenschappen per contractregel vastleggen (1 product met verschillende looptijden)",
                    "Aparte omschrijving vastleggen",
                    "Koppelen aan een verkooporder",
                    "Ingangsdatum contractregel vastleggen",
                    "Einddatum of expiratiedatum contractregel vastleggen",
                    "Contract- en factuurregels automatisch verlengen na einddatum",
                    "Herinneringsdatum contract- factuurregel vastleggen",
                    "Laatste verlengdatum contract- factuurregel vastleggen",
                    "Overzicht eerste generatiemoment contract- factuurregel",
                    "Overzicht einde vorige interval contract- factuurregel",
                    "Overzicht begin volgende interval contract- factuurregel",
                    "Opmerking contract- factuurregel vastleggen",


                },
                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Plannings interval",
                        Link = "http://hybridsaas.support/pages/support-site/modules/contractbeheer/plannings-interval"
                    },
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/algemene_contract_gegevens.png",
                        Title = "Contractgegevens op één centrale plaats",
                        Description = "Je krijgt de mogelijk om alle noodzakelijke contractgegevens op één plaats te beheren. Of het nu gaat om de contactgegevens of een referentie van je klant hier is het mogelijk. Koppel abonnementen eenvoudig aan bedrijven, personen of projecten. Doormiddel van templates en sjablonen maak je in een handomdraai een professionele overeenkomst in je eigen huisstijl."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/interval_en_duur_instellen.png",
                        Title = "Beheer looptijden van je contracten",
                        Description = "Of een contract per maand of per jaar gefactureerd dient te worden maakt niet meer uit. Leg eenvoudig de looptijd van het abonnement vast en bepaal het moment waarop de facturatie moet plaatsvinden. Automatisch incasseren van het abonnement is geen probleem."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/contractwaarde_overzicht.png",
                        Title = "Alle contracten overzichtelijk op een rij",
                        Description = "Alle verkoopcontracten en abonnementen in één duidelijk overzicht. In één oogopslag de contractwaarde en resterende looptijd per abonnement. Nooit meer zorgen maken of een contract wel of niet gefactureerd."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/variabele_looptijden_per_contractregel.png",
                        Title = "Looptijden per contractregel beheren",
                        Description = "Wanneer je één product verkoopt met verschillende looptijden kan je makkelijk en overzichtelijk vastleggen. Factuurregels met dezelfde periode worden netjes gebundeld terwijl afwijkende periodes separaat worden weergegeven. Je factuur is nog nooit zo duidlelijk geweest."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/planning_periodieke_facturen.png",
                        Title = "Overzichtelijke planning  van de aankomende facturen",
                        Description = "Wil je weten welke facturen er voor de komende tijd op de planning staan? In een duidelijk overzicht krijg je informatie over de facturen voor de komende periodes. Aan de hand van aantallen en bedragen zie je snel eventuele onregelmatigheden. Tevens zie je gelijk welke facturen reeds verzonden zijn of welke facturen nog verzonden dienen te worden"
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/contractregels_koppelen_ aan_prepaidkaart_en_grootboekrekening.png",
                        Title = "Ieder contract- en factuurregel een eigen grootboekrekening",
                        Description = "Optimale flexibiliteit, doordat je per regel details kunt vastleggen. Bepaal aan welke grootboekrekening of BTW percentage de contract- en factuuregel gekoppeld dient te worden. Prijzen, omschrijvingen worden automatisch voor je ingevuld doordat je gebruik maakt van de productencatalogus. Werk je met prepaidkaarten dan worden saldo’s automatisch gemuteerd."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/factuuregels_contract.png",
                        Title = "Factuur met uitgebreide specificaties",
                        Description = "Facturen zijn nog nooit zo duidelijk geweest. Doordat factuuregels tot in het kleinste details vastgelegd worden krijg je de mogelijkheid duidelijke en gedetailleerde gegevens op je factuur te laten zien."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/getekende_overeenkomst_digitaal_opslaan.png",
                        Title = "Getekende overeenkomst opslaan",
                        Description = "Ordners (hang) mappen behoren tot het verleden. Getekende contracten en abonnementsovereenkomsten scan je eenvoudig in en sla je op bij je digitale contract. Heb je bijlagen of andere digitale bestanden, dan sla je deze overzichtelijk online op. Alles centraal en digitaal op één plaats. "
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/inkoopcontracten_en_abonnementen_vastleggen_bij_contract.png",
                        Title = "Koppel inkoopcontracten aan verkoopcontracten",
                        Description = "Je klant zegt het contract bij jou op en je vergeet je inkoopcontract stop te zetten. Dit zal je vanaf nu nooit meer overkomen. Automatisch krijg je een bericht als je een contract beëindigd. Tevens krijg je in duidelijk overzicht van al jou inkoopverplichtingen behorend bij je abonnementen"
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/commissies_beheren.png",
                        Title = "Provisie en commissiebeheer",
                        Description = "Verkopen doe je niet alleen! Werk je met partners of agenten die jouw producten of diensten verkopen dan draag je eenvoudig provisies en commissies af. Op basis van het contract of zelfs factuurregels stuur je een helder overzicht van alle provisies over een bepaalde periode. Eenmalig instellen en “klaar is Kees”."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/contracten_verwerken.png",
                        Title = "Met één druk op de knop contract opmaken en versturen",
                        Description = "Waarom zou je veel tijd moeten spenderen aan terugkerende facturen die elke periode hetzelfde zijn? Met één druk op de knop worden al je contracten en abonnementen omgezet in een factuur. Jij bepaalt zelf naar wie en wat je factureert."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/automtische_incasso_contracten_en_abonnementen.png",
                        Title = "Koppelen met je financiële administratie en automatische incasso via SEPA",
                        Description = "Al je verzonden facturen worden overzichtelijk weergegeven op basis van grootboekrekeningen. Zie precies waar je omzet vandaan komt en waar extra aandacht nodig is. Abonnementskosten worden automatisch geïncasseerd bij de bank zodat je niet onnodig lang op je geld hoeft te wachten. "
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/contractbeheer/order_omzetten_in_contract.png",
                        Title = "Met één druk orders omzetten in een contract",
                        Description = "Het aanmaken van een nieuw of bestaand contract is abonnement is nog nooit zo makkelijk geweest. Op basis van een order zet je in een handomdraai alle gegevens om in een contract. Is je contract aangemaakt dan gaat de facturatie vanaf nu lekker vanzelf."
                    }
                },
            };
            LinkDictionary[Link.Correspondentie] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Correspondentie",
                Url = "/Module/Correspondentie",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Correspondentie",
                ImageBig = "/images/module_iconen/over-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/correspondentie1.jpg",
                        Title = "Correspondentie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/correspondentie2.jpg",
                        Title = "Correspondentie",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Extranet] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Extranet",
                Url = "/Module/Extranet",
                Description = "",
                IntroText = "",
                Image = "/images/module_iconen/extranet-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Extranet",
                ImageBig = "/images/module_iconen/extranet-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/extranet1.jpg",
                        Title = "Extranet",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/extranet2.jpg",
                        Title = "Extranet",
                        Description = "."
                    }
                },

            };
            
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Facturatie",
                Url = "/Module/facturatie",
                Quote = "Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen. ",
                IntroText = "Een goede cashflow begint bij het op tijd versturen van je facturen. Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen.",
                Description = "Je maakt gebruik van vooraf ingestelde gegevens. Op deze manier win je veel tijd en wordt de kans op fouten aanzienlijk verkleind. Facturen worden overzichtelijk opgeslagen en zijn hierdoor eenvoudig terug te vinden. Het verzenden van kopie- en creditfacturen was nog nooit zo gemakkelijk. Daarnaast geeft de module altijd het actuele facturatieproces weer en kun je in één oogopslag zien welke facturen zijn afgehandeld en welke er nog openstaan. Wanneer een betalingstermijn van een factuur is verstreken kunnen er gemakkelijk en snel betalingsherinneringen worden verstuurd.",
                Image = "/images/module_iconen/facturatie-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Facturatie",
                ImageBig = "/images/module_iconen/facturatie-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/facturatie1.jpg",
                        Title = "Facturatie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/facturatie2.jpg",
                        Title = "Facturatie",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Overzicht van de facturen per status",
                        Link = "http://hybridsaas.support/pages/support-site/modules/facturatie/herinneren-per-status/herinneren-per-status"
                    },
                    new ManualItem
                    {
                        Name = "Overzicht van de openstaande facturen met dagen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/facturatie/herinneren-per-klant/herinneren-per-klant"
                    }
                }
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Financieel",
                Url = "/Module/Financieel",
                IntroText = "Wil je het boekhoudproces nog slimmer inrichten? Kies dan ons pakket Financieel. Dit is de perfecte aanvulling op bijvoorbeeld Tickets & Facturatie ",
                Quote = "Van het versturen van facturen tot een actueel overzicht in de balans, winst- en verliesrekening; dit pakket is zo ontworpen dat het voor 100% aansluit op de andere pakketten van Hybrid SaaS.",
                Description = "Wij hebben zelf een boekhoudpakket ontwikkeld waarmee je eenvoudig digitaal online de complete boekhouding bijhoudt. Van het versturen van facturen tot een actueel overzicht in de balans, winst- en verliesrekening; dit pakket is zo ontworpen dat het voor 100% aansluit op de andere pakketten van Hybrid SaaS.",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 125,- per maand",
                LinkName = "Financieel",
                ImageBig = "/images/module_iconen/over-90.png",


                FactSheet = new List<string>
                {
                    "Bespaar op accountant kosten",
                    "Altijd inzicht in de actuele betaalstatus",
                    "Informatie op verschillende plekken raadplegen",
                    "Koppeling met de Nederlandse bank",
                    "Beschikking over realtime informatie",
                    "Budgetten vaststellen en bewaken",
                    "Makkelijk en snel wijzigingen doorgeven",
                    "Eenvoudig facturen opzoeken voor eventuele garantievraagstukken",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/financieel1.jpg",
                        Title = "Houd debiteuren- en crediteurenbeheer overzichtelijk",
                        Description = "Zie in één oogopslag de status van facturen en onderneem direct actie als dat nodig is. Sorteer de facturen op de manier die jij zelf handig vindt. Dit kan bijvoorbeeld op klant, maar ook op vervaldatum of aantal herinneringen. Hoe vaak en hoe snel een klant een herinnering moet ontvangen, leg je zelf vast in het systeem. "
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/financieel2.jpg",
                        Title = "Banktransacties inlezen",
                        Description = "Lees de banktransacties in en koppel ze eenvoudig aan openstaande verkoop- en inkoopfacturen. Maak incassobatches aan en dien deze in bij de bank. Zo kun je afschrijvingen direct koppelen aan de grootboekrekening of gegevens van inkoopfacturen automatisch gebruiken voor betalingen en incasso's. Je hoeft de gegevens maar 1 keer in te vullen, dus je hebt nooit meer dubbel werk."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/financieel3.jpg",
                        Title = "Stuur meerdere herinneringen tegelijk",
                        Description = "Zie je dat er meerdere facturen te lang openstaan? Stuur alle betrokkenen gemakkelijk een herinnering. Dat scheelt je veel tijd en is voor klanten zeer overzichtelijk."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/financieel4.jpg",
                        Title = "Weet altijd alles over de financiële positie van je organisatie",
                        Description = "Met het Hybrid SaaS boekhoudpakket weet je zeker dat jou geen financiële verrassingen te wachten staan. Je kunt altijd zien hoe je ervoor staat door de balans, winst- en verliesrekening te openen. Zo kun je dit zelf aanpassen. Door op de verschillende posten van de rekeningen te klikken, krijg je alle informatie tot in detail te zien. Dit kan duidelijkheid scheppen of fouten aan het licht brengen. Is het tijd om de administratie naar de belasting te brengen? Dan kan jouw boekhouder met een eigen inlogcode de rekeningen controleren. Correcties aanbrengen kan direct in de rekening als dat nodig is. Daarna exporteer je het bestand naar Excel."
                    }
                },
            };
            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Gebouwbeheer",
                Url = "/Module/Gebouwbeheer",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/gebouwen-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Gebouwbeheer",
                ImageBig = "/images/module_iconen/gebouwen-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/gebouw1.jpg",
                        Title = "Gebouwbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/gebouw1.jpg",
                        Title = "Gebouwbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Hrm] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Human Resource Management (HRM)",
                Url = "/Module/human-resource-management",
                IntroText = "Met Hybrid SaaS Human Resource Management kun je personeelszaken eenvoudig automatiseren en heb je altijd een up-to-date inzicht in de gehele personeelsadministratie. ",
                Description = "Alle personeelsgegevens staan op één centrale veilige plaats en zaken als contactgegevens, dienstverband en verlofuren kunnen altijd en overal worden geraadpleegd. Het zogenoemde Employee Self Service (ESS) maakt het mogelijk dat medewerkers zelf veranderingen en aanvragen in kunnen dienen. Deze worden vervolgens door de betreffende manager goedgekeurd en definitief doorgevoerd.",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Human Resource Management (HRM)",
                ImageBig = "/images/module_iconen/over-90.png",

                FactSheet = new List<string>
                {
                    "Medewerker contactgegevens vastleggen",
                    "Legitimatiegegevens vastleggen",
                    "Digitale kopie van legitimatiebewijs opslaan",
                    "Dienstverband vastleggen",
                    "Digitale kopie van (getekend) arbeidscontract opslaan",
                    "Verlof- en vakantierooster vastleggen",
                    "Familiegegevens vastleggen",
                    "Nood- en medische gegevens vastleggen",
                    "Certificaten en opleidingen vastleggen",
                    "Medewerkers koppelen aan groepen",
                    "Bedrijfsmiddelen (inventaris) registreren",
                    "Arbeidscontracten opstellen op basis van sjablonen",
                    "Correspondentiebrieven opstellen",
                    "Adreslabels opmaken en uitprinten",
                    "Arbeidscontracten opstellen",
                    "Verlofverzoeken indienen",
                    "Verlofverzoeken goedkeuren",
                    "Bedrijfsagenda met overzicht van alle verlofdagen per medewerker en bedrijfsactiviteiten",
                    "Actueel overzicht van alle vakantiesaldo’s per medewerker",
                    "Overzicht van medewerkers exporten naar Microsoft Excel",
                    "Overzicht openstaande verlofaanvragen",
                    "Overzicht verwerkte verlofaanvragen",
                    "Roosters exporten naar Microsoft Excel",
                    "Lokale bestanden opslaan bij medewerker",
                    "Algemene opmerkingen toevoegen bij een medewerker",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/hrm1.jpg",
                        Title = "Human Resource Management (HRM",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/hrm2.jpg",
                        Title = "Human Resource Management (HRM",
                        Description = "."
                    }
                },


                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Nieuw rooster aanmaken.",
                        Link = "http://hybridsaas.support/pages/support-site/modules/hrm/rooster-aanmaken/rooster-aanmaken."
                    }
                }
            };
            LinkDictionary[Link.Inventarisbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Inventarisbeheer",
                Url = "/Module/inventarisbeheer",
                IntroText = "Uw heeft diverse objecten in uw bezit, maar geen idee waar deze zich bevinden. Laat staan dat u snel handleidingen, inkoopfacturen of serienummers kunt opzoeken. ",
                Description = "Met Online Inventarisbeheer van Hybrid SaaS kunnen gegevens over uw inventaris overzichtelijk worden geregistreerd en gecontroleerd. Bij elk object kunt u aankooprijs, identificatienummers en diverse data vastleggen.",
                Image = "/images/module_iconen/inventarisbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Inventarisbeheer",
                ImageBig = "/images/module_iconen/inventarisbeheer-90.png",

                FactSheet = new List<string>
                {
                    "Inventaris registreren onder een bedrijf",
                    "Inventaris registreren onder een persoon",
                    "Inventaris registreren onder een medewerker",
                    "Leverancier vastleggen",
                    "Inventaristype vastleggen",
                    "Omschrijving en serienummer vastleggen",
                    "Diverse data vastleggen (installatie uitleendatum, garantie, retour e.d.)",
                    "Inkoopfactuur koppelen aan inventarisstuk",
                    "Opmerkingen opslaan bij inventarisstukken",
                    "Tickets opmaken bij inventarisstuk",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/inventaris1.jpg",
                        Title = "Inventarisbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/inventaris2.jpg",
                        Title = "Inventarisbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Inkoopbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Inkoopbeheer",
                Url = "/Module/Inkoopbeheer",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Inkoopbeheer",
                ImageBig = "/images/module_iconen/over-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/inkooporder1.jpg",
                        Title = "Inkoopbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/inkooporder1.jpg",
                        Title = "Inkoopbeheer",
                        Description = "."
                    }
                },



                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Transactie inkoopfactuur verwijderen uit SEPA betaalbatch",
                        Link = "http://hybridsaas.support/pages/support-site/modules/inkoopbeheer/ongedaan-maken-uit-sepa-batch/inkoopfactuur-ongedaan-maken-uit-sepa-betaal-batch"
                    },
                    new ManualItem
                    {
                        Name = "Inkoopfacturen via SEPA",
                        Link = "http://hybridsaas.support/pages/support-site/modules/inkoopbeheer/inkoopfacturen-via-sepa/inkoopfacturen-via-sepa"
                    }
                }
            };
            LinkDictionary[Link.KmRegistratie] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Km -Registratie",
                Url = "/Module/km-registratie",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/kmregistratie-45.png",
                Price = "€ 30,- per maand",
                ImageBig = "/images/module_iconen/kmregistratie-90.png",
                LinkName = "Km -Registratie",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/kmregistratie1.jpg",
                        Title = "Km -Registratie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/kmregistratie2.jpg",
                        Title = "Km -Registratie",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Notities",
                Url = "/Module/Notities",
                IntroText = "Met de Module Notities kan je eenvoudig een verslag bijhouden wat er is afgesproken met de klant. Je kan hem inplannen zodat hij een dag van te voren als je een afspraak heb staan weer naar voren komt. ",
                Description = "Ook kan je er bijlage in bijhouden. Dus alle relevante informatie over het gesprek word bij elkaar bewaard zodat je het altijd terug kan vinden",
                Image = "/images/module_iconen/notities-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Notities",
                ImageBig = "/images/module_iconen/notities-90.png",

                FactSheet = new List<string>
                {
                    "Notities aanmaken op bedrijven",
                    "Notities aanmaken op personen",
                    "Notities aanmaken op projecten",
                    "Actiedatum toekennen (incl. herinneringsdatum)",
                    "Begin- en eindtijd vastleggen",
                    "Notitie toewijzen aan medewerker",
                    "Notities afhandelen",
                    "Digitale bijlagen opslaan",
                    "Datumstempel toevoegen aan notitie",
                    "Bestanden toevoegen aan een notitie",
                    "Notities exporteren naar Microsoft Excel",
                    "Notities omzetten naar agenda items in Microsoft Outlook",
                    "Notities mailen via Microsoft Outlook",
                    "Notities omzetten in tijdregistraties",
                    "Notities koppelen aan categorieën",
                    "Document opmaken van een notitie",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Notities",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Notities",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.OffertesOrders] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Offertes & Orders",
                Url = "/Module/offertes-orders",
                IntroText = "In een handomdraai een professionele offerte opstellen en daarna vliegensvlug omzetten in een order? Dat kan! Met de module Hybrid SaaS Offertes & Orders. Eenmalig stel je een offerte lay-out op, waarna je alleen nog maar de producten of diensten als offerteregels hoeft toe te voegen. ",
                Description = "Deze basis kan na acceptatie van de offerte dienen als order, werkbon en/of pakbon, waarbij alleen de lay-out verandert. De offerte dan wel order kan rechtstreeks digitaal verzonden worden vanuit Hybrid SaaS.",
                Image = "/images/module_iconen/offerteorders-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Offertes & Orders",
                ImageBig = "/images/module_iconen/offerteorders-90.png",

                FactSheet = new List<string>
                {
                    "Notities aanmaken op bedrijven",
                    "Offertes en orders opstellen",
                    "Offertes en orders opstellen voor een Bedrijf",
                    "Offertes en orders opstellen voor een Persoon",
                    "Offertes en orders koppelen aan een project",
                    "Diverse offerte- en ordergegevens vastleggen",
                    "Offerte en orderregels aanmaken uit een productendatabase",
                    "Scanfunctie om snel offerte- en orderregels toe te voegen",
                    "Offerte omzetten in order",
                    "Offerte en orders omzetten in een factuur",
                    "Offerte en orders omzetten in proforma factuur",
                    "Offerte en orders omzetten in een contract",
                    "Offertes en orders digitaal versturen via e-mail",
                    "Offertes en orders uitprinten",
                    "Offertes en orders opmaken in Microsoft Word",
                    "Diverse offerte en ordersjablonen aanmaken",
                    "Offertes en orders dupliceren",
                    "Afwijkend factuur- en afleveradres vastleggen",
                    "Diverse order statussen ingeven en vastleggen",
                    "Diverse geautomatiseerde offerte statussen",
                    "Diverse geautomatiseerde bestelling statussen",
                    "Diverse geautomatiseerde productie statussen",
                    "Diverse geautomatiseerde uitvoering statussen",
                    "Diverse geautomatiseerde webshop statussen",
                    "Diverse data vastleggen (offerte-, order-, leveringsdatum e.d.)",
                    "Offerte- en orderkorting vastleggen",
                    "Offerte- en orderkorting vastleggen per regel",
                    "Verzendmethode vastleggen",
                    "Vrije teksten invoeren bij een offerte of order",
                    "Offerte en order historie inzien",
                    "Offerte en ordermarges weergeven ten opzichte van inkoopprijs",
                    "Overzichten exporten naar Microsoft Excel",
                    "Opvolgingsdata invoeren",
                    "Commissieregels vastleggen",
                    "Opmerkingen en notities vastleggen",
                    "Ticket aanmaken op een offerte of order",
                    "Online bestanden opslaan bij offertes en orders",
                    "Lokaal bestanden opslaan bij offertes en orders",
                    "Digitale kopie van getekende offertes en orders opslaan",
                    "Betalingsinformatie inzien",
                    "Actiehistorie inzien",
                    "Diverse offerte- en orderschema’s vastleggen",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Offertes & Orders",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Offertes & Orders",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Een order afhandelen met voorraad",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/offerte-afhandelen-met-voorraad/een-order-afhandelen-met-voorraad"
                    },
                    new ManualItem
                    {
                        Name = "Een order afhandelen zonder voorraad",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/order-afhandelen-zonder-voorraad/een-order-afhandelen-zonder-voorraad"
                    },
                    new ManualItem
                    {
                        Name = "Een offerte of order aanmaken",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/offerte-order-aanmaken/een-offerte-of-order-aanmaken"
                    },
                    new ManualItem
                    {
                        Name = "Zicht-Consignatie factuur",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/zicht-consignatie-factuur-aanmaken/zicht-consignatie-factuur-aanmaken"
                    },
                    new ManualItem
                    {
                        Name = "Zicht-Consignatie factuur omzetten naar Retour/Factuur",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/zicht-consignatie-factuur-omzetten/zicht-consignatie-factuur-omzetten"
                    },
                    new ManualItem
                    {
                        Name = "Betaalwijze aanpassen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/offertes-orders/betaalwijze-aanpassen/betaalwijze-aanpassen"
                    }
                }
            };
            LinkDictionary[Link.Onderaannemer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Onderaannemer",
                Url = "/Module/Onderaannemer",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Onderaannemer",
                ImageBig = "/images/module_iconen/over-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Onderaannemer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Onderaannemer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.OutlookAddIn] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Outlook Add-In",
                Url = "/Module/Outlook-Add-in",
                IntroText = "Door middel van de Outlook Add-in krijg je de mogelijkheid om e-mails vanuit Microsoft Outlook mailbox om te zetten in tickets. ",
                Description = "Op deze manier kan je je mailbox leeg houden en sla je e-mails netjes op bij de juiste relaties en/ of projecten.",
                Image = "/images/module_iconen/outlookaddon-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Outlook Add-In",
                ImageBig = "/images/module_iconen/outlookaddon-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Outlook Add-In",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Outlook Add-In",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Outlook Add-in installeren",
                        Link = "http://hybridsaas.support/pages/support-site/modules/outlook-addin/installeren/outlook-add-in-installeren"
                    },
                    new ManualItem
                    {
                        Name = "Handige weetjes",
                        Link = "http://hybridsaas.support/pages/support-site/modules/outlook-addin/handige-weetjes/handige-weetjes"
                    }
                }
            };
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Prepaidkaarten",
                Url = "/Module/Prepaidkaarten",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/prepaidkaarten-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Prepaidkaarten",
                ImageBig = "/images/module_iconen/prepaidkaarten-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Prepaidkaarten",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Prepaidkaarten",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Productenbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Productenbeheer",
                Url = "/Module/productenbeheer",
                IntroText = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Image = "/images/module_iconen/productbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Productenbeheer",
                ImageBig = "/images/module_iconen/productbeheer-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Productenbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Productenbeheer",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Importeren Producten",
                        Link = "http://hybridsaas.support/pages/support-site/modules/productenbeheer/importeren/producten-importeren-cms"
                    }
                }
            };
            LinkDictionary[Link.Prognosebeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Prognosebeheer",
                Url = "/Module/prognosebeheer",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Prognosebeheer",
                ImageBig = "/images/module_iconen/over-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Prognosebeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Prognosebeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Projectbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Url = "/Module/Projectbeheer",
                Name = "Projectbeheer",
                Quote = "De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven.",
                IntroText = "Met de module Projectbeheer worden alle projectgegevens op één centrale plaats vastgelegd. De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven. ",
                Description = "Met Hybrid SaaS Projectbeheer ben je in staat om projecten eenvoudiger te managen. Ook kun je deadlines gemakkelijk monitoren, openstaande taken inzien en het vastgestelde budget bewaken. Per project kun je financiële afspraken vastleggen en altijd en overal de projecthistorie inzien. Offertes en facturen kunnen eenvoudig aan projecten worden gekoppeld en met één druk op de knop worden verstuurd. Kortom, een forse tijdbesparing!",
                Image = "/images/module_iconen/projectbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Projectbeheer",
                ImageBig = "/images/module_iconen/projectbeheer-90.png",

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Project planning maken",
                        Link = "http://hybridsaas.support/pages/support-site/modules/projectbeheer/projectplanning/projectplanning"
                    }
                }
            };


            LinkDictionary[Link.Relatiebeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Relatiebeheer",

                Url = "/Module/relatiebeheer",
                IntroText = "Relaties zijn de motor van iedere organisatie. Juist daarom is het belangrijk om als organisatie over een compleet en overzichtelijk CRM-systeem (Customer Relationship Management) te beschikken. ",
                Description = "Met de module Relatiebeheer van Hybrid SaaS kunnen klantgegevens gemakkelijk en snel worden vastgelegd. Bovendien heeft elke medewerker altijd en overal toegang tot de actuele gegevens en de historie van elke klant. Dit is ook voor de klant een goede zaak, want dit zorgt voor een optimale klantbediening.",
                Image = "/images/module_iconen/relatiebeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Relatiebeheer",
                ImageBig = "/images/module_iconen/relatiebeheer-90.png",

                FactSheet = new List<string>
                {
                    "Leads",
                    "Klanten",
                    "Leveranciers",
                    "Fabrikanten",
                    "Overige",
                    "Extranet gebruikers",
                    "Personen",
                    "Correspondentie archief",
                    "Account managers",
                    "Exporteren",
                    "Tijdlijn weergeven",
                    "Nieuwsbriefaanmeldingen",
                    "Document (sjabloon) schema",
                    "Factuurkortingen vastleggen",
                    "Bankrekeningen vastleggen bij bedrijven en personen",
                    "Accountmanagers vastleggen bij relaties",
                    "Vestigingen vastleggen bij bedrijven",
                    "Certificaten koppelen aan bedrijven",
                    "Abonnementen koppelen aan bedrijven",
                    "Prijsafspraken vastleggen bij bedrijven",
                    "Extranet gegevens vastleggen bij bedrijven",
                    "Status toekennen aan relaties",
                    "Online bestanden opslaan bij relaties",
                    "Lokaal bestanden opslaan bij relaties",
                    "Personen koppelen aan bedrijven",
                    "Personen inzien bij bedrijven",
                    "Projecten inzien bij bedrijven en personen",
                    "Verkoopfacturen inzien bij bedrijven en personen",
                    "Orders inzien bij bedrijven en personen",
                    "Inkoopfacturen inzien bij bedrijven en personen",
                    "Banktransacties inzien bij bedrijven en personen",
                    "Tickets inzien en aanmaken bij bedrijven en personen",
                    "Correspondentiebrieven en documenten opstellen op basis van sjablonen",
                    "Contactgegevens exporteren naar Microsoft Outlook",
                    "Mailing versturen naar diverse relaties in een bepaalde groep/ segment",
                    "Notities opmaken, beheren en toewijzen",
                    "Overzichten exporten naar Microsoft Excel",
                    "Contacten importen via Microsoft Excel",
                    "Correspondentiearchief bijhouden",
                    "Verjaardag herinneringsfunctie"
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Relatiebeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Relatiebeheer",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Relatie importeren",
                        Link = "http://hybridsaas.support/pages/support-site/modules/relatiebeheer/importeren/relatie-import"
                    }
                }
            };


            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Ticketsysteem",

                Url = "/Module/ticket-systeem",
                Quote = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen",
                IntroText = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen. Weet precies wat er speelt bij je relaties, projecten en je eigen organisatie. Met behulp van de juiste categorieën en urgentie bepaal je zelf waar de prioriteiten liggen en heb je altijd een actueel overzicht. ",
                Description = "Op deze manier krijg je een beter inzicht in openstaande acties en verhoog je de efficiëntie en servicegerichtheid naar je (klant) relaties. Communicatie is misschien wel het belangrijkste element voor een goede samenwerking. Ons doel is bedrijven en hun relaties dichter bij elkaar te brengen om op deze manier een optimale samenwerking te realiseren. Klantvragen komen via verschillende kanalen binnen en worden vaak op verschillende plaatsen opgeslagen. Door de inefficiënte gaat veel tijd verloren en gooi je onnodig geld weg. Het ticketsysteem van Hybrid SaaS biedt veel mogelijkheden om dit te voorkomen en is vrijwel door ieder bedrijf te gebruiken.",
                Image = "/images/module_iconen/ticketsysteem-45.png",
                Price = "€ 40,- per maand",
                LinkName = "Ticketsysteem",
                ImageBig = "/images/module_iconen/ticketsysteem-90.png",
            FactSheet = new List<string>
                {
                    "Tickets aanmaken via Extranet anoniem",
                    "Tickets aanmaken via Extranet met logingegevens",
                    "Tickets koppelen aan bedrijven, personen, projecten en werklocaties",
                    "Ticketstatus aanmaken",
                    "Tickets categoriseren",
                    "Tickets toewijzen aan afdelingen en medewerkers",
                    "Opmerkingen toevoegen aan tickets",
                    "Tickets uitstellen en parkeren",
                    "Vervolgtickets aanmaken",
                    "Log en tickethistorie bijhouden",
                    "Statusupdates versturen naar betrokkenen",
                    "Digitale bijlagen opslaan bij tickets",
                    "Online bestanden toevoegen aan tickets",
                    "Milestones toekennen aan tickets",
                    "Prognose start- en eindtijd ingeven",
                    "Daadwerkelijke start- en eindtijd ingeven",
                    "Tijd registreren op tickets",
                    "Documenten opmaken op een ticket",
                    "Overzicht van tickets op verschillende dagen",
                    "Overzicht tickets per afdeling of gebruiker",
                    "Overzicht exporten naar Microsoft Excel",
                    "Ticketdocument digitaal versturen",
                    "Ticketdocument uitprinten",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Ticketsysteem",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Ticketsysteem",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Ticketupdate per afdeling en/of gebruiker Instellen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/ticketsysteem/per-gebruiker-afdeling-instellen/ticketupdate-per-gebruiker-bepalen"
                    }
                }
            };

            LinkDictionary[Link.Tijdregistratie] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Tijdregistratie",
                Url = "/Module/tijdregistratie",
                Quote = "Met Hybrid SaaS Tijdregistratie kan iedere medewerker op elke gewenst moment snel en eenvoudig uren, onkosten en kilometers registreren.",
                IntroText = "Het bijhouden van gewerkte uren wordt door medewerkers vaak als een tijdrovende klus beschouwd. Mede hierdoor wordt deze taak nogal eens uitgesteld en worden er achteraf dikwijls foutieve gegevens vastgelegd. ",
                Description = "Maar daar komt vanaf nu verandering in. Met Hybrid SaaS Tijdregistratie kan iedere medewerker op elke gewenst moment snel en eenvoudig uren, onkosten en kilometers registreren. Op deze manier creëer je meer uniformiteit, tijden worden accurater bijgehouden en je beschikt altijd en overal over de meest actuele gegevens.",
                Image = "/images/module_iconen/tijdregistratie-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Tijdregistratie",
                ImageBig = "/images/module_iconen/tijdregistratie-90.png",

                FactSheet = new List<string>
                {
                    "Tijd registreren op projecten (bedrijven en personen)",
                    "Begin-, eindtijd en pauzes registreren",
                    "Omschrijving en interne opmerking ingeven",
                    "Notities aanmaken op tijdregistraties",
                    "(om)kosten registreren",
                    "(om)kosten registreren uit de producten database",
                    "Tijdregistraties beoordelen door diverse afdelingen",
                    "Bewijsregistratie bijvoegen",
                    "Digitale bestanden toevoegen",
                    "Tijd registreren via extranet en mobiel apparaat",
                    "Tijd registreren via agenda items Microsoft Outlook",
                    "Diverse tijdregistratie statussen in diverse processen",
                    "Overzichten exporten naar Microsoft Excel",
                    "Inkoopstuk derden aanmaken op basis van tijdregistraties",
                    "Tijdregistraties factureren (per tijdvak, medewerker project, opdrachtgever)",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Tijdregistratie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Tijdregistratie",
                        Description = "."
                    }
                },


                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Overwerk",
                        Link = "http://hybridsaas.support/pages/support-site/modules/tijdregistratie/overwerk/overwerk"
                    },
                    new ManualItem
                    {
                        Name = "Product toevoegen aan je tijdregistratie",
                        Link = "http://hybridsaas.support/pages/support-site/modules/tijdregistratie/product-toevoegen/product-toevoegen"
                    },
                    new ManualItem
                    {
                        Name = "Reiskosten doorbelasten",
                        Link = "http://hybridsaas.support/pages/support-site/modules/tijdregistratie/reiskosten/reiskosten"
                    },
                    new ManualItem
                    {
                        Name = "Verwerking verschillende overuren",
                        Link = "http://hybridsaas.support/pages/support-site/modules/tijdregistratie/verwerking-verschillende-overuren/verwerking-verschillende-overuren"
                    }
                }
            };
            LinkDictionary[Link.Voorraadbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Voorraadbeheer",
                Url = "/Module/voorraadbeheer",
                IntroText = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Image = "/images/module_iconen/voorraadbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Voorraadbeheer",
                ImageBig = "/images/module_iconen/voorraadbeheer-90.png",

                FactSheet = new List<string>
                {
                    "Producten categoriseren in hoofd- en subgroepen",
                    "Productgroepen koppelen aan grootboekrekeningen en werkcodes",
                    "Productdetails en –informatie vastleggen",
                    "Beschrijving",
                    "Barcode",
                    "Productcode",
                    "Leverancierscode",
                    "Eenheid",
                    "Afmetingen",
                    "Materialen",
                    "Kleur",
                    "Gewicht",
                    "Verkoopprijs inclusief of exclusief BTW (eventueel variabel)",
                    "Inkoopprijs (eventueel variabel)",
                    "Basis verkoopprijs (eventueel variabel)",
                    "Basis inkoopprijs (eventueel variabel)",
                    "Verpakkingseenheid",
                    "Productafbeelding opslaan",
                    "Opmerkingen aanmaken",
                    "Producten onderverdelen in sub producten (productonderdelen)",
                    "Gerelateerde producten vastleggen",
                    "Producten dupliceren",
                    "Product labels en barcodes aanmaken",
                    "Gekoppelde orders inzien bij producten",
                    "Overzichten exporten naar Microsoft Excel",
                    "Producten importen via Microsoft Excel",
                    "Producten weergeven op de webshop",
                    "Multi talig CMS teksten voor webshop vastleggen",
                    "Kenmerken (tags) vastleggen",
                    "Actuele voorraad van producten inzien",
                    "Laatste inkoopprijs (LIP) per product",
                    "Gemiddelde inkoopprijs (GIP) van actuele voorraad",
                    "Voorraadlocaties vastleggen",
                    "Productielocaties vastleggen",
                    "Actuele voorraad inzien",
                    "Actuele gereserveerde voorraad inzien",
                    "Actuele voorraad in backorder",
                    "Actuele producten gereserveerd voor bestelling",
                    "Actuele vrije voorraad",
                    "Leveringsaanvragen via Extranet maken",
                    "Openstaande voorraad verplaatsingen inzien",
                    "Voorraad inboeken (op locaties)",
                    "Voorraad muteren",
                    "Voorraad historie raadplegen",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Voorraadbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Voorraadbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Voortgang] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Voortgang",
                Url = "/Module/voortgang",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Voortgang",
                ImageBig = "/images/module_iconen/over-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Voortgang",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Voortgang",
                        Description = "."
                    }
                },

              };
            LinkDictionary[Link.VragenlijstenEquettes] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Vragenlijst & Equettes",
                Url = "/Module/vragenlijsten",
                IntroText = "Informatie is misschien wel het belangrijkste onderdeel binnen elke organisatie. Maar hoe zorgt u ervoor dat u de juiste informatie krijgt, zonder dat er een hele papierstroom aan vooraf gaat.",
                Description = " Met de Online Enquête en vragenlijsten van Hybrid SaaS kunt u klanttevredenheidsonderzoeken uitvoeren, gestandaardiseerde (voor) opnamelijsten en nog veel meer. U heeft de volledige vrijheid om zelf vragen op te stellen en deze te laten beantwoorden door middel van multiple choice of open antwoorden.",
                Image = "/images/module_iconen/vragenlijst-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Vragenlijst & Equettes",
                ImageBig = "/images/module_iconen/vragenlijst-90.png",

                FactSheet = new List<string>
                {
                    "Vragenlijsten opstellen bij bedrijven, personen, medewerkers en projecten",
                    "Openvragen toevoegen op vragenlijst",
                    "Multiple choice vragen toevoegen op vragenlijst",
                    "Overzicht ingevulde en afgehandelde vragenlijsten",
                    "Een tekening toevoegen aan de vragenlijst",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Vragenlijst & Equettes",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Vragenlijst & Equettes",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Implementatie",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/instalatie-werkplek/instalatie-werkplek"
                    },
                    new ManualItem
                    {
                        Name = "Een tekening toevoegen aan de vragenlijst",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/tekening-toevoegen/tekening-toevoegen"
                    },
                    new ManualItem
                    {
                        Name = "Het instellen van de vragenlijst",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/instellingen/vragenlijsten-instellingen"
                    },
                    new ManualItem
                    {
                        Name = "Beheren van de vragenlijst",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/beheren/vragenlijsten-beheren"
                    },
                    new ManualItem
                    {
                        Name = "Vragenlijst extranet",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/via-extranet/vragenlijsten-extranet"
                    },
                    new ManualItem
                    {
                        Name = "Vragenlijst invoeren op je mobiel",
                        Link = "http://hybridsaas.support/pages/support-site/modules/vragenlijst%20-equettes/invoeren/vragenlijsten-invoeren"
                    }
                }
            };
            LinkDictionary[Link.Wachtwoordbeheer] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Wachtwoordbeheer",
                Url = "/Module/wachtwoordbeheer",
                IntroText = "Je heb zoveel verschillende websites en zoveel verschillende inloggegevens dat je het overzicht zo kwijt ben welk wachtwoord waarbij hoort. ",
                Description = "In deze module kunt u wachtwoorden registreren en koppelen aan het bedrijf zodat u altijd uw wachtwoorden bij de hand heeft.",
                Image = "/images/module_iconen/wachtwoordbeheer-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Wachtwoordbeheer",
                ImageBig = "/images/module_iconen/wachtwoordbeheer-90.png",

                FactSheet = new List<string>
                {
                    "Wachtwoorden registreren bij bedrijven",
                    "Wachtwoorden registreren bij personen",
                    "Wachtwoorden registreren bij medewerkers",
                    "Opmerkingen vastleggen",
                    "Overzicht exporten naar Microsoft Excel",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Wachtwoordbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Wachtwoordbeheer",
                        Description = "."
                    }
                },
                
            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Webshop",
                Url = "/Module/webshop",
                Quote = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden. ",
                IntroText = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden.",
                Description = "Met een webshop ben je niet locatie gebonden en 24 uur per dag, 7 dagen per week bereikbaar. De uitgelezen kans om nieuwe klanten aan te trekken en de behoeften van bestaande klanten te voorzien. Online winkelen, het nieuwe winkelen!",
                Image = "/images/module_iconen/webshop-45.png",
                Price = "€ 30,- per site",
                LinkName = "Webshop",
                ImageBig = "/images/module_iconen/webshop-90.png",
                
                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Webshop",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Webshop",
                        Description = "."
                    }
                },

                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Menu paden",
                        Link = "http://hybridsaas.support/pages/support-site/modules/webshop/menupaden/menupaden"
                    }
                }
            };
            LinkDictionary[Link.Werkbonnen] = new LinkInfo
            {
                Type = LinkType.Module,

                Name = "Werkbonnen",
                Url = "/Module/werkbonnen",
                IntroText = "Buitendienstmedewerkers zijn veel tijd kwijt aan het invullen van papieren werkbonnen. Waarom zou u onnodig papier en tijd verspillen, terwijl uw werkbonnen gedigitaliseerd kunnen worden. ",
                Description = " Met de digitale werkbon kunnen uw buitendienstmedewerkers snel een eenvoudig werkzaamheden en kosten registreren. Het overtypen van handgeschreven werkbonnen behoort tot het verleden. De communicatietijd zal verkleinen terwijl u de efficiëntie verhoogd. Doordat de werkbonnen direct gekoppeld zijn aan uw backoffice heeft u altijd en over een actueel overzicht.",
                Image = "/images/module_iconen/werkbonnen-45.png",
                Price = "€ 30,- per maand",
                LinkName = "Werkbonnen",
                ImageBig = "/images/module_iconen/werkbonnen-90.png",

                FactSheet = new List<string>
                {
                    "Werkbonnen aanmaken via extranet (bijv telefoon of tablet)",
                    "Werkbonnen koppelen aan projecten en medewerkers",
                    "Werktijd registreren op werkbon (zie tijdregistratie)",
                    "Kosten registreren",
                    "Kosten registreren op basis van producten uit productenlijst",
                    " Marge op basis van kosten en opbrengsten visualiseren",
                    "Werkbeschrijving ingeven",
                    "Werkbonnen goedkeuren door diverse afdelingen",
                    "Werkbonnen factureren (direct, per maand, kwartaal of jaar)",
                    "Digitaal document opstellen",
                    "Tickets aanmaken bij werkbonnen",
                    "Werkbon (bezoekrapport) versturen per email",
                    "Actiehistorie inzien per werkbon",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Werkbonnen",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Werkbonnen",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.GebruikerIntern] = new LinkInfo
            {
                Name = "Gebruikers",
                Url = "/Module/Gebruiker-intern",
                IntroText = "Alles bijhouden in de backoffice Gebruikers van Hybrid  SaaS kunnen inloggen in de applicatie om o.a. de processen te volgen van het bedrijf, het versturen van de facturen of het controleren van de tijdregistraties",
                Quote = "Alles bijhouden in de backoffice Gebruikers van Hybrid  SaaS kunnen inloggen in de applicatie om o.a. de processen te volgen van het bedrijf, het versturen van de facturen of het controleren van de tijdregistraties",
                Description = "",
                Image = "/images/module_iconen/gebrintern-45.png",
                Price = "€ 5,- per gebruiker",
                LinkName = "Gebruikers",
                ImageBig = "/images/module_iconen/gebrintern-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Gebruikers",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Gebruikers",
                        Description = "."
                    }
                },


                ManualItems = new List<ManualItem>
                {
                    new ManualItem
                    {
                        Name = "Handtekening",
                        Link = "http://hybridsaas.support/pages/support-site/modules/gebruikers/handtekening/handtekening"
                    },
                    new ManualItem
                    {
                        Name = "Wachtwoord vergeten",
                        Link = "http://hybridsaas.support/pages/support-site/modules/gebruikers/wachtwoord-vergeten/wachtwoord-vergeten"
                    },
                    new ManualItem
                    {
                        Name = "Wachtwoord versturen",
                        Link = "http://hybridsaas.support/pages/support-site/modules/gebruikers/wachtwoord-versturen/wachtwoord-versturen"
                    }
                }
            };
            LinkDictionary[Link.GebruikerExtern] = new LinkInfo
            {
                Name = "Buitendienst medewerkers",
                Url = "/Module/Gebruiker-extern",
                IntroText = "Doormiddel van onze Extranet versie voor de mobiel of tablet, kunnen je medewerkers gemakkelijk hun werkbriefjes opvragen of hun tijdregistraties te noteren",
                Quote = "Doormiddel van onze Extranet versie voor de mobiel of tablet, kunnen je medewerkers gemakkelijk hun werkbriefjes opvragen of hun tijdregistraties te noteren",
                Description = "",
                Image = "/images/module_iconen/gebrextern-45.png",
                Price = "€ 10,- per 10 medewerkers",
                LinkName = "Buitendienst medewerkers",
                ImageBig = "/images/module_iconen/gebrextern-90.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/modules/buitendienstmedewerker1.jpg",
                        Title = "Buitendienst medewerkers",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/modules/buitendienstmedewerker2.jpg",
                        Title = "Buitendienst medewerkers",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            {
                Name = "Dataopslag",
                Url = "/Module/Dataopslag",
                IntroText = "Alle digitale kopieën, documenten, gegevens van relaties en vele andere data, word opgeslagen in de applicatie, zodat de inforamtie altijd beschikbaar is",
                Quote = "Alle digitale kopieën, documenten, gegevens van relaties en vele andere data, word opgeslagen in de applicatie, zodat de informatie altijd beschikbaar is",
                Description = "",
                Image = "/images/module_iconen/dataopslag-45.png",
                Price = "€ 10,- per 10 GB",
                LinkName = "Dataopslag 10 GB",
                ImageBig = "/images/module_iconen/dataopslag-90.png",
                
            };


            //modulles hebben nog geen pagina

            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            {

                Name = "Export externe boekhouding",
                Url = "/Module/exportboekhouding",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/exportnaarboekhouding-45.png",
                Price = "€ 30,- per extern boekhoudpakket",
                LinkName = "Export externe boekhouding",
                ImageBig = "/images/module_iconen/exportnaarboekhouding-90.png",

            };
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            {

                Url = "/Module/Externpakket",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "€ 30,- per extern pakket",
                LinkName = "Export extern pakket",
                ImageBig = "/images/module_iconen/over-90.png",
            };
           LinkDictionary[Link.InkoopfacturatieCrediteurenbeheer] = new LinkInfo
            {
                Url = "/inkoopfacturatie-en-crediteurenbeheer",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "InkoopfacturatieCrediteurenbeheer",
                ImageBig = "/images/advantage_img7.png",


            };
            
             
            LinkDictionary[Link.ExportExcel] = new LinkInfo
            { 
                Url = "/Module/Excel-export",
                IntroText = "",
                Description = "",
                Image = "/images/module_iconen/over-45.png",
                Price = "",
                LinkName = "Export naar Excel",
                ImageBig = "/images/module_iconen/over-90.png",


            };
            LinkDictionary[Link.Email] = new LinkInfo
            { 
                Url = "#",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "E-mail",
                ImageBig = "/images/advantage_img7.png",


            };
           
            
            
            LinkDictionary[Link.Termijnstatenbeheer] = new LinkInfo
            {
                Url = "/Module/Termijnstatenbeheer",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Termijnstatenbeheer",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Meerwerk] = new LinkInfo
            {
                Url = "/Module/Meerwerk",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Meerwerk",
                ImageBig = "/images/advantage_img7.png",
            };





            //pakketten


            LinkDictionary[Link.MenuPakketten] = new LinkInfo
            {
                Name = "Pakketten",
                Url = "/pakketten",

                IntroText = "Ga naar de pakketten-overzichts pagina",
                PageTitle = "Pakketten overzicht",
                ImageBig = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 300,- per maand",
                LinkName = "Pakket Offerte & Voorraad",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketErp] = new LinkInfo
            {
                Url = "/pakket-erp",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 500,- per maand",
                LinkName = "Pakket Erp",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketKwaliteitsControleTickets] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle-tickets",
                Quote = "",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 250,- per maand",
                LinkName = "Pakket KwaliteitsControle & Tickets",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketKwaliteitsControle] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle",
                IntroText = "In de Bouw wordt er vaak in verschillende fases gewerkt waarbij je als ondernemer altijd afhankelijk bent van de partij die voor je werkt en die na je komt. Discussies over begin- en eindsituaties worden vaak lange tijd na oplevering en zonder goede onderbouwing gevoerd. Dit kost veel tijd en vaak zonder veel resultaat. Hoe mooi zou als er in de Bouw betere digitale communicatie komt die processen verbeterd en discussies kan voorkomen of verminderen.",
                Quote = "Voor het vroegtijdig signaleren en rapporteren van afwijkingen in het proces.",
                Description = "Met het professionele online business software pakket kwaliteitscontrole van Hybrid SaaS dragen wij er zorg voor dat discussies met goede digitale onderbouwing worden aangegaan. Door middel van een vooraf samengestelde vragenlijst leg je vraag en antwoord eventueel aangevuld met bijbehorende foto(‘s) eenvoudig vast.",
                DescriptionRight = "Met deze mobiele oplossing is het tijdperk van geschreven briefjes die zoek raken verleden tijd. Altijd en overal gegevens vastleggen en direct versturen zorgt voor een efficiënte communicatie voor- tijdens en na iedere fase. Vragenlijsten zijn makkelijk zelfstandig te maken en te beheren.",
                Image = "/images/ticket_icon3a.png",
                Price = "€ 100,- per maand",
                LinkName = "Pakket Kwaliteitscontrole",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie",
                Quote = "Voor het bijhouden van alle acties in het bedrijf en het doorbelasten van de gewerkte tijd",
                IntroText = "De e-mails, telefoontjes, tekst- en whatsappberichten van klanten vliegen je om de oren. Een van je klanten stelt ondertussen ook nog een ingewikkelde vraag waar meerdere lagen in de organisatie bij betrokken zijn. Niemand weet meer wat de actuele status is van de vraag. Hoeveel tijd er precies besteed is aan het oplossen van het vraagstuk weet al helemaal niemand meer. Conclusie: Je mist het overzicht en laat daarmee veel geld liggen, terwijl dat nergens voor nodig is! Wij hebben de bewezen oplossing om jouw problemen op te lossen.",
                Description = "Met het professionele online business software pakket Tickets & Facturatie van Hybrid SaaS weet je zeker dat je voortaan geen zorgen meer hebt over tickets, tijdregistratie en facturatie. Het ervaren en gedreven team van Hybrid SaaS heeft krachtige software ontwikkeld die precies doet wat jij wilt. Wij steven naar perfectie en constante verbetering  van onze producten zodat jij altijd overzicht en inzicht hebt. ",
                DescriptionRight = "Hybrid SaaS is een Nederlands product, gebaseerd op Nederlandse business logica met een professionele Nederlandse klantenservice. Bij ons hoef je niet bang te zijn voor vervelende verrassingen. We communiceren graag met onze klanten in heldere taal en vragen een eerlijke, betaalbare prijs voor onze producten.",
                Image = "/images/ticket_icon2a.png",
                Price = "€ 250,- per maand",
                LinkName = "Pakket Tickets & Facturatie",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketContractbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer",
                Quote = "Voor het periodiek factureren van (cloud) diensten",
                IntroText = "Als ICT-dienstverlener heb je een oneindige hoeveelheid contracten lopen bij klanten en leveranciers. Inkoopcontracten voor de eigen organisatie, maar ook inkoopcontracten voor klanten die weer gekoppeld zijn aan verkoopcontracten tussen jouw organisatie en de klant.",
                Description = "Met Contractbeheer heb je eenvoudig inzicht in alle lopende contracten. Loopt een contract met een klant af, dan zie je direct welke contracten bij derden uitstaan en welke bijvoorbeeld opgezegd moeten worden.",
                Image = "/images/ticket_icon1.png",
                Price = "€ 125,- per maand",
                LinkName = "Pakket Contractbeheer",
                ImageBig = "/images/advantage_img7.png",


            };

            //support

            LinkDictionary[Link.WordAddDownload] = new LinkInfo
            { 
                Url = "https://download.hybridsaas.com/install/word/setup.exe",
                IntroText = "Hybrid SaaS Word add-in",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS Word add-in",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS Browser",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/office/outlook/",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS Outlook add-in",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.DataAdapter] = new LinkInfo
            {
                Url = "https://downloadsite.blob.core.windows.net/dataadapter/dataadapter.zip",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS DataAdapter",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.FotoAdapter] = new LinkInfo
            {
                Url = "https://downloadsite.blob.core.windows.net/hybrid-saas-tools/tools.exe",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS FotoAdapter",
                ImageBig = "/images/advantage_img7.png",


            };

            LinkDictionary[Link.KijkMetMijMee] = new LinkInfo
            { 
                Url = "http://www.kijkmetmijmee.nl/Hybrid%20SaaS%20-%20Customer%20Support.exe",
                IntroText = "",
                Description = "Wij kunnen op afstand meekijken op uw computer, gebruik deze optie om onze medewerkers toegang te geven tot uw pc.",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Kijk met mij mee",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.InvoerTicket] = new LinkInfo
            {
                Url = "https://hybridsaas.hybridsaas.com/Extranet-revisited/Ticket/Ticket.create.asp",
                IntroText = "Wij zijn met vakantie van 21-12-2015 t/m 03-01-2016. Uw vraag wordt na de vakantie in behandeling genomen",
                Description = "Stel snel en gemakkelijk uw vraag online aan onze organisatie. ",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Ticketsysteem",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.HelpDesk] = new LinkInfo
            {
                Url = "#",
                IntroText = "",
                Description = "Onze contact gegevens.",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Helpdesk",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Handleiding] = new LinkInfo
            {
                Url = "http://hybridsaas.support/pages",
                IntroText = "",
                Description = "Onze uitgebreide handleiding geeft inzicht in de werking van onze software.",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Handleiding",
                ImageBig = "/images/handleiding-hs.png",


            };
            LinkDictionary[Link.Download] = new LinkInfo
            {
                Url = "",
                IntroText = "Downloads",
                Description = "Downloads",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Downloads",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Consultancy] = new LinkInfo
            {
                Url = "",
                IntroText = "Consultancy",
                Description = "Maak gebruik van onze jarenlange kennis als systeembeheerder, softwareontwikkelaar & bedrijfsautomatiseerder.",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Consultancy",
                ImageBig = "/images/advantage_img7.png",


            };


            //overige

            LinkDictionary[Link.LicentieVoorwaardenPdf] = new LinkInfo
            { 
                Url = "http://www.hybridsaas.com/PDF/Licentievoorwaarden.pdf",


            };
            LinkDictionary[Link.AlgemeneVoorwaardenPdf] = new LinkInfo
            { 
                Url = "http://www.hybridsaas.com/PDF/Algemene voorwaarden Hybrid SaaS ICT BV.pdf",


            };

            LinkDictionary[Link.Prijzenlijst] = new LinkInfo
            {
                Url = "/Prijzenlijst",
                Name = "Prijzenlijst"
            };
            LinkDictionary[Link.prijzenlijstmodulesPdf] = new LinkInfo
            {
                Url = "http://www.hybridsaas.com/PDF/Modules.pdf",
            };

            LinkDictionary[Link.prijzenlijstpakkettenPdf] = new LinkInfo
            {
                Url = "http://www.hybridsaas.com/PDF/Pakketten.pdf",


            };
            LinkDictionary[Link.prijzenlijstimplementatiePdf] = new LinkInfo
            {
                Url = "http://www.hybridsaas.com/PDF/Implementatie-Inrichting.pdf",
            };


            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "http://hybridsaas.support/pages",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Meest Gestelde Vragen",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.MenuContact] = new LinkInfo
            {
                Name = "Contact",
                Url = "/contact",
                IntroText = "Ga naar de contactpagina",
                PageTitle = "Contactgegevens"
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet",
                IntroText = "",
                Description = "",
                Image = "images/why_arrow.png",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.MenuHome] = new LinkInfo
            {
                Name = "Home",
                Url = "/",

                IntroText = "Ga naar de startpagina",
                PageTitle = "Welkom bij Hybrid SaaS",
                ImageBig = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Name = "Release notes",
                Url = "http://hybridsaas.support/pages/support-site/release-notes/volgende-release/volgende-release",
                IntroText = "Ga naar de release notes",
                OpenInNewWindow = true
            };
            LinkDictionary[Link.MenuSupport] = new LinkInfo
            {
                Name = "Support",
                Url = "/support",
                IntroText = "Ga naar de support pagina",

                PageTitle = "Supportpagina",
                ImageBig = "/images/advantage_img7.png",
            };


            LinkDictionary[Link.MenuOver] = new LinkInfo
            {
                Name = "Over",
                Url = "/over",

                IntroText = "Over ons",
                ImageBig = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie",
                Name = "YouTube",
                OpenInNewWindow = true,
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map",
                Name = "Sitemap",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.AlgemeneVoorwaarden] = new LinkInfo
            {
                Url = "/algemene-voorwaarden",
                Name = "Algemene voorwaarden"

            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Administratie] = new LinkInfo
            { //not init
                Url = "#",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Administratie",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Alles] = new LinkInfo
            { //not init
                Url = "#",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Alles",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Overig] = new LinkInfo
            {//not init
                Url = "#",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Overige",
                ImageBig = "/images/advantage_img7.png",

};


            /*var file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\robots.txt";
            string content = "";
            foreach (var item in LinkDictionary.Values)
            {
                content += "Allow: "+item.Url + Environment.NewLine;
            }
            File.WriteAllText(file,content);*/
        }
    }
}