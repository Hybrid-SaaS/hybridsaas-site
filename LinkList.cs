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


    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Name;
            public string LinkName = "";

            public string Url = "#";
            
            public string IntroText = "";

            //indien pagetitle leeg is, valt deze terug naar introtext
            public string PageTitle;
            public string Description = "";
            
            public string Image = "";
            public string ImageBig = "";

            public string Price = "";

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
        


        static LinkList()
        {

            //modules

            LinkDictionary[Link.MenuModules] = new LinkInfo
            {
                Name = "Modules",
                Url = "/modules",

                IntroText = "Ga naar de module-overzichts pagina",
                PageTitle = "Module overzicht",
                Price = "Vanaf € 30,- per maand",
                LinkName = "Modules",
                Image = "/images/why_arrow.png",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Abonnementen",
                Url = "/Module/Abonnementen",
                IntroText = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Description = "De module Hybrid SaaS Abonnementenbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige abonnementen. Met Hybrid SaaS Abonnementenbeheer loop je nooit meer achter de feiten aan.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Abonnementen",
                ImageBig = "/images/advantage_img7.png",
                

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Abonnementen",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Abonnementen",
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

            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Name = "Bankrekening",
                Url = "/Module/bankrekening",
                IntroText = "De module Bankrekeningen schept orde in de chaos. U kan eenvoudig banktransacties importeren en afletteren waardoor u altijd inzicht heeft in de openstaande en betaalde facturen.",
                Description = "Lees de banktransacties in en koppel ze eenvoudig aan openstaande verkoopfacturen. Het is ook mogelijk om incassobatches aan te maken. Het inlezen van banktransacties is ook handig voor de verwerking van inkoopfacturen. Zo kun je afschrijvingen direct koppelen aan de grootboekrekening of gegevens van inkoopfacturen automatisch gebruiken voor betalingen en incasso's.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Bankrekening",
                ImageBig = "/images/advantage_img7.png",

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
                        Image = "/images/foto_img.jpg",
                        Title = "Bankrekening",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
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
                Name = "Balans Winst & Verliesrekening",
                Url = "/Module/balans-winst-verliesrekening",
                IntroText = "De balans & winsten verliesrekening is een kasstroomoverzicht en daarmee een onderdeel van een jaarrekening. De balans & winst en verliesrekening geeft een overzicht van de kosten en opbrengsten van de entiteit over een bepaalde periode (meestal een jaar). ",
                Description = "Het saldo van de balans & winst en verliesrekening is de over de periode behaalde winst of het over de periode geleden verlies. In dit artikel wordt het proces om een balans & winst en verliesrekening op te maken beschreven. Voordat u een Balans & Winst en verliesrekening kunt opmaken dient u eerst de basis inrichting uit te voeren",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Balans Winst & Verliesrekening",
                ImageBig = "/images/advantage_img7.png",

                FactSheet = new List<string>
                {
                    "Winst- en verlies rekening opstellen",
                    "Balans opstellen",
                    "Memoriaal boekingen aanmaken en inzien",
                    "Zoeken op grootboekrekeningnummers",
                    "Overzichten afdrukken",
                    "Overzicht exporten naar Mircosoft Excel",
                    "Verkoop facturen exporteren naar ander boekhoudsysteem (Exact Online, Exact Globe, Accountview)",
                    "Inkoop facturen exporteren naar ander boekhoudsysteem (Exact Online, Exact Globe, Accountview)",
                    "Verkoopboek inzien",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Balans Winst & Verliesrekening",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Balans Winst & Verliesrekening",
                        Description = "."
                    }
                },
            };

            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Name = "Bedrijfsagenda",
                Url = "/Module/bedrijfsagenda",
                IntroText = "Met de bedrijfsagenda kan je heel eenvoudig het rooster van je mederwerkers bijhouden, je kan in één opslag zien hoeveel uur een mederwerker nog heeft staan of al heeft opgenomen. ",
                Description = "Vanuit de bedrijfagenda kan je makkelijk een ticket aanmaken en inplannen, een verlof aanvragen of een bedrijfsgebeurtenis aanmaken. Je kan per mederwerker ook een export naar excel maken zodat je makkelijk kunt zien wanneer er vrij is genomen of ziek is geweest.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Bedrijfsagenda",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Bedrijfsagenda",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Bedrijfsagenda",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Name = "Certificatenbeheer",
                Url = "/Module/certificatenbeheer",
                IntroText = "Eenvoudig kunnen zien wanneer een het rijbewijs of paspoort verloopt van je persooneel verloopt? Hybrid SaaS maakt het mogelijk! ",
                Description = "De module Certificatenbeheer schept orde in de chaos en plaatst alle certificaten overzichtelijk bij elkaar.Wanneer een certificaat tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Zodat je gegevens altijd op orde zijn.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Certificatenbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                        Image = "/images/foto_img.jpg",
                        Title = "Certificatenbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Certificatenbeheer",
                        Description = "."
                    }
                },
            };

            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Name = "Commissiebeheer",
                Url = "/Module/commissciebeheer",
                IntroText = "Werk je met resellers? Dan is Commissiebeheer van Hybrid SaaS zeker interessant voor jouw organisatie. ",
                Description = "Met Commissiebeheer zorg je ervoor dat de registraties en betalingen van provisies altijd op orde zijn. Voor iedere factuur die jij verstuurt rekenen wij uit hoeveel commissie je af dient te dragen aan wederverkopers, resellers of agenten. Of je nu werkt met Tickets & Facturatie, Contractbeheer of Offerte & Voorraad, Commissiebeheer sluit naadloos aan bij al deze pakketten.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Commissiebeheer",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Beheer commissies per relatie",
                        Description = "In een tabel leg je vast welke relatie welke commissie ontvangt. Kies meteen een begin en einddatum. Stel bijvoorbeeld in dat er voor twee jaar commissie wordt uitgekeerd. De provisie boek je meteen op de grootboekrekening. Van de uitgekeerde commissie maak je eenvoudig een inkoopstuk. Verder kun je in deze module per relatie aangeven hoeveel commissie er wordt uitgekeerd, of er sprake is van een bonus en/of een korting. Ook zorg je ervoor dat de commissie pas betaald wordt als de factuur is voldaan."
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
                Name = "Contractenbeheer",
                Url = "/Module/contractenbeheer",
                IntroText = "Waarom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? Met Hybrid SaaS Contracten heb je nauwelijks omkijken naar je periodiek uitgaande facturen en bestellingen en zo verbeter je eenvoudig je positieve cashflow.",
                Description = "Periodiek terugkerende bestellingen plaats je automatisch bij je leveranciers. Abonnementen van je klanten kunnen worden ingegeven, waarbij de factuur per ingegeven termijn wordt verstuurd. Verzend facturen en bestellingen direct via e-mail. Bestaande orders en facturen kunnen direct geautomatiseerd worden.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Contractenbeheer",
                ImageBig = "/images/advantage_img7.png",

                FactSheet = new List<string>
                {
                    "Periodieke facturen/ contracten instellen",
                    "Frequentie bepalen (maand, kwartaal, jaar)",
                    "Contractwaarde instellen (maand, kwartaal, jaar)",
                    "Meerdere contractregels invoeren met eigen werkcode",
                    "Commissieafdracht vastleggen",
                    "Contracten dupliceren",
                    "Documenten opmaken bij contracten",
                    "Automatisch commissies uitrekenen per contractregel",
                    "Contractduur vastleggen",
                    "Herinneringsdatum vastleggen",
                    "Generatiemoment (moment van factureren) vastleggen",
                    "Contracten samenvoegen",
                    "Digitale kopie opslaan",
                    "Online bestanden opslaan bij contracten",
                    "Overzicht lopende contracten",
                    "Overzicht vervallen contracten",
                    "Overzichten exporten naar Microsoft Excel",
                    "Contracten factureren per type, organisatie of persoon",
                    "Contracten automatisch samenvoegen",
                    "Facturenoverzicht per contract inzien",
                },

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Contractenbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Contractenbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Crm] = new LinkInfo
            {
                Name = "Crm",
                Url = "/Module/Crm",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Crm",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Crm",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Crm",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Correspondentie] = new LinkInfo
            {
                Name = "Correspondentie",
                Url = "/Module/Correspondentie",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Correspondentie",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Correspondentie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Correspondentie",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.FacturatieDebiteurbeheer] = new LinkInfo
            {
                Name = "Debiteurbeheer",
                Url = "/Module/debiteurbeheer",
                IntroText = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk! ",
                Description = "De module Hybrid SaaS facturatie-debiteurbeheerbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar. Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige facturatie-debiteurbeheer. Met Hybrid SaaS facturatie-debiteurbeheerbeheer loop je nooit meer achter de feiten aan.",
                Image = "images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Debiteurbeheer",
                ImageBig = "images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Debiteurbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Debiteurbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Extranet] = new LinkInfo
            {
                Name = "Extranet",
                Url = "/Module/Extranet",
                Description = "De module Hybrid SaaS Extranetbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige Extranet. Met Hybrid SaaS Extranetbeheer loop je nooit meer achter de feiten aan.",
                IntroText = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Image = "/images/modules_img5.png",
                Price = "€ 30,- per maand",
                LinkName = "Extranet",
                ImageBig = "/images/advantage_img7.png",
                
            };
            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            {
                Name = "Export externe boekhouding",
                Url = "/Module/exportboekhouding",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per extern boekhoudpakket",
                LinkName = "Export externe boekhouding",
                ImageBig = "/images/advantage_img7.png",
                
            };
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            {
                Url = "/Module/Externpakket",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Export extern pakket",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Name = "Facturatie",
                Url = "/Module/facturatie",
                IntroText = "Een goede cashflow begint bij het op tijd versturen van je facturen. Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen.",
                Description = "Je maakt gebruik van vooraf ingestelde gegevens. Op deze manier win je veel tijd en wordt de kans op fouten aanzienlijk verkleind. Facturen worden overzichtelijk opgeslagen en zijn hierdoor eenvoudig terug te vinden. Het verzenden van kopie- en creditfacturen was nog nooit zo gemakkelijk. Daarnaast geeft de module altijd het actuele facturatieproces weer en kun je in één oogopslag zien welke facturen zijn afgehandeld en welke er nog openstaan. Wanneer een betalingstermijn van een factuur is verstreken kunnen er gemakkelijk en snel betalingsherinneringen worden verstuurd.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Facturatie",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Facturatie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
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
                Name = "Financieel",
                Url = "/Module/Financieel",
                IntroText = "Wil je het boekhoudproces nog slimmer inrichten? Kies dan ons pakket Financieel. Dit is de perfecte aanvulling op bijvoorbeeld Tickets & Facturatie of Offerte & Voorraad.",
                Description = "Wij hebben zelf een boekhoudpakket ontwikkeld waarmee je eenvoudig digitaal online de complete boekhouding bijhoudt. Van het versturen van facturen tot een actueel overzicht in de balans, winst- en verliesrekening; dit pakket is zo ontworpen dat het voor 100% aansluit op de andere pakketten van Hybrid SaaS.",
                Image = "/images/why_arrow.png",
                Price = "€ 125,- per maand",
                LinkName = "Financieel",
                ImageBig = "/images/advantage_img7.png",


                FactSheet = new List<string>
                {
                    "Bespaar op accountantkosten",
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
                        Image = "/images/foto_img.jpg",
                        Title = "Houd debiteuren- en crediteurenbeheer overzichtelijk",
                        Description = "Zie in één oogopslag de status van facturen en onderneem direct actie als dat nodig is. Sorteer de facturen op de manier die jij zelf handig vindt. Dit kan bijvoorbeeld op klant, maar ook op vervaldatum of aantal herinneringen. Hoe vaak en hoe snel een klant een herinnering moet ontvangen, leg je zelf vast in het systeem. "
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Banktransacties inlezen",
                        Description = "Lees de banktransacties in en koppel ze eenvoudig aan openstaande verkoop- en inkoopfacturen. Maak incassobatches aan en dien deze in bij de bank. Zo kun je afschrijvingen direct koppelen aan de grootboekrekening of gegevens van inkoopfacturen automatisch gebruiken voor betalingen en incasso's. Je hoeft de gegevens maar 1 keer in te vullen, dus je hebt nooit meer dubbel werk."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Stuur meerdere herinneringen tegelijk",
                        Description = "Zie je dat er meerdere facturen te lang openstaan? Stuur alle betrokkenen gemakkelijk een herinnering. Dat scheelt je veel tijd en is voor klanten zeer overzichtelijk."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Weet altijd alles over de financiële positie van je organisatie",
                        Description = "Met het Hybrid SaaS boekhoudpakket weet je zeker dat jou geen financiële verrassingen te wachten staan. Je kunt altijd zien hoe je ervoor staat door de balans, winst- en verliesrekening te openen. Zo kun je dit zelf aanpassen. Door op de verschillende posten van de rekeningen te klikken, krijg je alle informatie tot in detail te zien. Dit kan duidelijkheid scheppen of fouten aan het licht brengen. Is het tijd om de administratie naar de belasting te brengen? Dan kan jouw boekhouder met een eigen inlogcode de rekeningen controleren. Correcties aanbrengen kan direct in de rekening als dat nodig is. Daarna exporteer je het bestand naar Excel."
                    }
                },
            };
            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            {
                Name = "Gebouwbeheer",
                Url = "/Module/Gebouwbeheer",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Gebouwbeheer",
                ImageBig = "/images/advantage_img7.png",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Gebouwbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Gebouwbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Hrm] = new LinkInfo
            {
                Name = "Human Resource Management (HRM)",
                Url = "/Module/human-resource-management",
                IntroText = "Met Hybrid SaaS Human Resource Management kun je personeelszaken eenvoudig automatiseren en heb je altijd een up-to-date inzicht in de gehele personeelsadministratie. ",
                Description = "Alle personeelsgegevens staan op één centrale veilige plaats en zaken als contactgegevens, dienstverband en verlofuren kunnen altijd en overal worden geraadpleegd. Het zogenoemde Employee Self Service (ESS) maakt het mogelijk dat medewerkers zelf veranderingen en aanvragen in kunnen dienen. Deze worden vervolgens door de betreffende manager goedgekeurd en definitief doorgevoerd.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Human Resource Management (HRM)",
                ImageBig = "/images/advantage_img7.png",

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
                        Image = "/images/foto_img.jpg",
                        Title = "Human Resource Management (HRM",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
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
                Name = "Inventarisbeheer",
                Url = "/Module/inventarisbeheer",
                IntroText = "Uw heeft diverse objecten in uw bezit, maar geen idee waar deze zich bevinden. Laat staan dat u snel handleidingen, inkoopfacturen of serienummers kunt opzoeken. ",
                Description = "Met Online Inventarisbeheer van Hybrid SaaS kunnen gegevens over uw inventaris overzichtelijk worden geregistreerd en gecontroleerd. Bij elk object kunt u aankooprijs, identificatienummers en diverse data vastleggen.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Inventarisbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                        Image = "/images/foto_img.jpg",
                        Title = "Inventarisbeheer",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Inventarisbeheer",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Inkoopbeheer] = new LinkInfo
            {
                Url = "/Module/Inkoopbeheer",
                IntroText = "Inkoopbeheer",
                Description = "Inkoopbeheer",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Inkoopbeheer",
                ImageBig = "/images/advantage_img7.png",




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
                Name = "Km -Registratie",
                Url = "/Module/km-registratie",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                ImageBig = "/images/advantage_img7.png",
                LinkName = "Km -Registratie",

                PhotoItems = new List<PhotoItem>
                {
                    new PhotoItem
                    {
                        Image = "/images/foto_img.jpg",
                        Title = "Km -Registratie",
                        Description = "."
                    },
                    new PhotoItem
                    {
                        Image = "/images/foto_img1.jpg",
                        Title = "Km -Registratie",
                        Description = "."
                    }
                },
            };
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Name = "Notities",
                Url = "/Module/Notities",
                IntroText = "Met de Module Notities kan je eenvoudig een verslag bijhouden wat er is afgesproken met de klant. Je kan hem inplannen zodat hij een dag van te voren als je een afspraak heb staan weer naar voren komt.",
                Description = "Ook kan je er bijlage in bijhouden. Dus alle relevante informatie over het gesprek word bij elkaar bewaard zodat je het altijd terug kan vinden",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Notities",
                ImageBig = "/images/advantage_img7.png",

                FactSheet = new List<string>
                {
                    "Notities aanmaken op bedrijven",
                    "Notities aanmaken op personen",
                    "Notities aanmaken op projecten",
                    "Actiedatum toekennen (incl herinneringsdatum)",
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
                Name = "Offertes & Orders",
                Url = "/Module/offertes-orders",
                IntroText = "In een handomdraai een professionele offerte opstellen en daarna vliegensvlug omzetten in een order? Dat kan! Met de module Hybrid SaaS Offertes & Orders. Eenmalig stel je een offerte lay-out op, waarna je alleen nog maar de producten of diensten als offerteregels hoeft toe te voegen. ",
                Description = "Deze basis kan na acceptatie van de offerte dienen als order, werkbon en/of pakbon, waarbij alleen de lay-out verandert. De offerte dan wel order kan rechtstreeks digitaal verzonden worden vanuit Hybrid SaaS.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Offertes & Orders",
                ImageBig = "/images/advantage_img7.png",

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
                    "Offerte en orders omzetten in proformafactuur",
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
                    }
                }
            };
            LinkDictionary[Link.Onderaannemer] = new LinkInfo
            {
                Name = "Onderaannemer",
                Url = "/Module/Onderaannemer",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Onderaannemer",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Outlook Add-In",
                Url = "/Module/Outlook-Add-in",
                IntroText = "Door middel van de Outlook add-in krijg je de mogelijkheid om e-mails vanuit Microsoft Outlook mailbox om te zetten in tickets. ",
                Description = "Op deze manier kan je je mailbox leeg houden en sla je e-mails netjes op bij de juiste relaties en/ of projecten.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Outlook Add-In",
                ImageBig = "/images/advantage_img7.png",

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
                    }
                }
            };
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Name = "Prepaidkaarten",
                Url = "/Module/Prepaidkaarten",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Prepaidkaarten",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Productenbeheer",
                Url = "/Module/productenbeheer",
                IntroText = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Productenbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Prognosebeheer",
                Url = "/Module/prognosebeheer",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Prognosebeheer",
                ImageBig = "/images/advantage_img7.png",

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
                Url = "/Module/Projectbeheer",
                Name = "Projectbeheer",

                IntroText = "Met de module Projectbeheer worden alle projectgegevens op één centrale plaats vastgelegd. De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven.",
                Description = "Met Hybrid SaaS Projectbeheer ben je in staat om projecten eenvoudiger te managen. Ook kun je deadlines gemakkelijk monitoren, openstaande taken inzien en het vastgestelde budget bewaken. Per project kun je financiële afspraken vastleggen en altijd en overal de projecthistorie inzien. Offertes en facturen kunnen eenvoudig aan projecten worden gekoppeld en met één druk op de knop worden verstuurd. Kortom, een forse tijdbesparing!",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Projectbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Relatiebeheer",

                Url = "/Module/relatiebeheer",
                IntroText = "Relaties zijn de motor van iedere organisatie. Juist daarom is het belangrijk om als organisatie over een compleet en overzichtelijk CRM-systeem (Customer Relationship Management) te beschikken.",
                Description = ".Met de module Relatiebeheer van Hybrid SaaS kunnen klantgegevens gemakkelijk en snel worden vastgelegd. Bovendien heeft elke medewerker altijd en overal toegang tot de actuele gegevens en de historie van elke klant. Dit is ook voor de klant een goede zaak, want dit zorgt voor een optimale klantbediening.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Relatiebeheer",
                ImageBig = "/images/advantage_img7.png",

                FactSheet = new List<string>
                {
                    "Leads",
                    "Klanten",
                    "Leveranciers",
                    "Frabikanten",
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
                Name = "Ticketsysteem",

                Url = "/Module/ticket-systeem",
                IntroText = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen. Weet precies wat er speelt bij je relaties, projecten en je eigen organisatie. Met behulp van de juiste categorieën en urgentie bepaal je zelf waar de prioriteiten liggen en heb je altijd een actueel overzicht. ",
                Description = "Op deze manier krijg je een beter inzicht in openstaande acties en verhoog je de efficiëntie en servicegerichtheid naar je (klant) relaties. Communicatie is misschien wel het belangrijkste element voor een goede samenwerking. Ons doel is bedrijven en hun relaties dichter bij elkaar te brengen om op deze manier een optimale samenwerking te realiseren. Klantvragen komen via verschillende kanalen binnen en worden vaak op verschillende plaatsen opgeslagen. Door de inefficiënte gaat veel tijd verloren en gooi je onnodig geld weg. Het ticketsysteem van Hybrid SaaS biedt veel mogelijkheden om dit te voorkomen en is vrijwel door ieder bedrijf te gebruiken.",
                Image = "/images/why_arrow.png",
                Price = "€ 40,- per maand",
                LinkName = "Ticketsysteem",
                ImageBig = "/images/advantage_img7.png",
            FactSheet = new List<string>
                {
                    "Tickets aanmaken via Extranet anonien",
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
                Name = "Tijdregistratie",
                Url = "/Module/tijdregistratie",
                IntroText = "Het bijhouden van gewerkte uren wordt door medewerkers vaak als een tijdrovende klus beschouwd. Mede hierdoor wordt deze taak nogal eens uitgesteld en worden er achteraf dikwijls foutieve gegevens vastgelegd. ",
                Description = "Maar daar komt vanaf nu verandering in. Met Hybrid SaaS Tijdregistratie kan iedere medewerker op elke gewenst moment snel en eenvoudig uren, onkosten en kilometers registreren. Op deze manier creëer je meer uniformiteit, tijden worden accurater bijgehouden en je beschikt altijd en overal over de meest actuele gegevens.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Tijdregistratie",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Voorraadbeheer",
                Url = "/Module/voorraadbeheer",
                IntroText = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Voorraadbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                    "Producten onderverdelen in subproducten (productonderdelen)",
                    "Gerelateerde producten vastleggen",
                    "Producten dupliceren",
                    "Productlabels en barcodes aanmaken",
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
                Name = "Voortgang",
                Url = "/Module/voortgang",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Voortgang",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Vragenlijst & Equettes",
                Url = "/Module/vragenlijsten",
                IntroText = "Informatie is misschien wel het belangrijkste onderdeel binnen elke organisatie. Maar hoe zorgt u ervoor dat u de juiste informatie krijgt, zonder dat er een hele papierstroom aan vooraf gaat.",
                Description = " Met de Online Enquête en vragenlijsten van Hybrid SaaS kunt u klanttevredenheidsonderzoeken uitvoeren, gestandaardiseerde (voor) opnamelijsten en nog veel meer. U heeft de volledige vrijheid om zelf vragen op te stellen en deze te laten beantwoorden door middel van muliplechoice of open antwoorden.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Vragenlijst & Equettes",
                ImageBig = "/images/advantage_img7.png",

                FactSheet = new List<string>
                {
                    "Vragenlijsten opstellen bij bedrijven, personen, medewerkers en projecten",
                    "Openvragen toevoegen op vragenlijst",
                    "Muliplechoice vragen toevoegen op vragenlijst",
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
                Name = "Wachtwoordbeheer",
                Url = "/Module/wachtwoordbeheer",
                IntroText = "Je heb zoveel verschillende website's en zoveel verschillende inloggegevens dat je het overzicht zo kwijt ben welk wachtwoord waarbij hoort. ",
                Description = "In deze module kunt u wachtwoorden registreren en koppelen aan het bedrijf zodat u altijd uw wachtwoorden bij de hand heeft.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Wachtwoordbeheer",
                ImageBig = "/images/advantage_img7.png",

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
                Name = "Webshop",
                Url = "/Module/webshop",
                IntroText = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden.",
                Description = "Met een webshop ben je niet locatie gebonden en 24 uur per dag, 7 dagen per week bereikbaar. De uitgelezen kans om nieuwe klanten aan te trekken en de behoeften van bestaande klanten te voorzien. Online winkelen, het nieuwe winkelen!",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per site",
                LinkName = "Webshop",
                ImageBig = "/images/advantage_img7.png",
                
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
                Name = "Werkbonnen",
                Url = "/Module/werkbonnen",
                IntroText = "Buitendienstmedewerkers zijn veel tijd kwijt aan het invullen van papieren werkbonnen. Waarom zou u onnodig papier en tijd verspillen, terwijl uw werkbonnen gedigitaliseerd kunnen worden. ",
                Description = " Met de digitale werkbon kunnen uw buitendienstmedewerkers snel een eenvoudig werkzaamheden en kosten registreren. Het overtypen van handgeschreven werkbonnen behoort tot het verleden. De communicatietijd zal verkleinen terwijl u de efficiëntie verhoogd. Doordat de werkbonnen direct gekoppeld zijn aan uw backoffice heeft u altijd en over een actueel overzicht.",
                Image = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Werkbonnen",
                ImageBig = "/images/advantage_img7.png",

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
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 5,- per gebruiker",
                LinkName = "Gebruikers",
                ImageBig = "/images/advantage_img7.png",



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
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 10,- per 10 medewerkers",
                LinkName = "Buitendienst medewerkers",
                ImageBig = "/images/advantage_img7.png",
                
            };
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            {
                Name = "Dataopslag",
                Url = "/Module/Dataopslag",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "€ 10,- per 10 GB",
                LinkName = "10 GB dataopslag",
                ImageBig = "/images/advantage_img7.png",
                
            };


            //modulles hebben nog geen pagina


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
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Export naar Excel",
                ImageBig = "/images/advantage_img7.png",


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
                IntroText = "",
                Description = "",
                Image = "/images/ticket_icon3a.png",
                Price = "€ 100,- per maand",
                LinkName = "Pakket Kwaliteitscontrole",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie",
                IntroText = "",
                Description = "",
                Image = "/images/ticket_icon2a.png",
                Price = "€ 250,- per maand",
                LinkName = "Pakket Tickets & Facturatie",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketContractbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer",
                IntroText = "",
                Description = "",
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
                LinkName = "Hybrid SaaS word add-in",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS browser",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/office/outlook/",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS outlook add-in",
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
                IntroText = "",
                Description = "Stel snel en gemakkelijk uw vraag online aan onze organisatie.",
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
                Url = "http://www.hybridsaas.com/images/Algemene%20licentievoorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "LicentieVoorwaardenPdf",
                ImageBig = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.AlgemeneVoorwaardenPdf] = new LinkInfo
            { 
                Url = "http://www.hybridsaas.com/images/Algemene%20voorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "AlgemeneVoorwaardenPdf",
                ImageBig = "/images/advantage_img7.png",


            };
            
            LinkDictionary[Link.Prijzenlijst] = new LinkInfo
            {
                Url = "#",
                IntroText = "",
                Description = "",
                Image = "/images/why_arrow.png",
                Price = "",
                LinkName = "prijzenlijst",
                ImageBig = "/images/advantage_img7.png",
            };

            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "/Meest-gestelde-vragen",
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