using System;
using System.Collections.Generic;
using System.IO;

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
    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Name;
            public string Url = "#";
            public string Title = "";
            public string Description = "";

            //indien pagetitle leeg is, valt deze terug naar title
            public string PageTitle;
        }

        public static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();
        public static Dictionary<string, LinkInfo> UrlDictionary = new Dictionary<string, LinkInfo>(StringComparer.InvariantCultureIgnoreCase);

        public static string GetLink(Link link)
        {
            return LinkDictionary[link].Url;
        }
        public static string GetTitle(Link link)
        {
            return LinkDictionary[link].Title;
        }
        public static string GetDescription(Link link)
        {
            return LinkDictionary[link].Description;
        }

        static LinkList()
        {
            LinkDictionary[Link.PakketAanvullendFinancieel] = new LinkInfo
            {
                Url = "/pakket-aanvullend-financieel",
                
                
            };
            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "/Meest-gestelde-vragen",
                
                
            };
            LinkDictionary[Link.Commisie] = new LinkInfo
            {
                Url = "/Commissie",
                
                
            };
            LinkDictionary[Link.MenuContact] = new LinkInfo
            {
                Name = "Contact",
                Url = "/contact",
                Title = "Ga naar de contactpagina",
                PageTitle = "Contactgegevens"
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet",
                
                
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Url = "/Financieel",
                
                
            };
            LinkDictionary[Link.MenuHome] = new LinkInfo
            {
                Name = "Home",
                Url = "/",

                Title = "Ga naar de startpagina",
                PageTitle = "Welkom bij Hybrid SaaS"
            };
            LinkDictionary[Link.MenuModules] = new LinkInfo
            {
                Name = "Modules",
                Url = "/modules",

                Title = "Ga naar de module-overzichts pagina",
                PageTitle = "Module overzicht"
                
            };
            LinkDictionary[Link.PakketContractbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer",
                
                
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad",
                
                
            };
            LinkDictionary[Link.PakketErp] = new LinkInfo
            {
                Url = "/pakket-erp",
                
                
            };
            LinkDictionary[Link.PakketKwaliteitsControleTickets] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle-tickets",
                
                
            };
            LinkDictionary[Link.PakketKwaliteitsControle] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle",
                
                
            };
            LinkDictionary[Link.MenuPakketten] = new LinkInfo
            {
                Name = "Pakketten",
                Url = "/pakketten",

                Title = "Ga naar de pakketten-overzichts pagina",
                PageTitle = "Pakketten overzicht"
            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie",
                
                
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Url = "http://hybridsaas.support/pages/release-notes/latest/release-notes",
                
                
            };
            LinkDictionary[Link.MenuSupport] = new LinkInfo
            {
                Name = "Support",
                Url = "/support",
                Title = "Ga naar de support pagina",

                PageTitle = "Supportpagina"
            };
            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Url = "/Module/ticket-systeem",
                Title = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen. Weet precies wat er speelt bij je relaties, projecten en je eigen organisatie. Met behulp van de juiste categorieën en urgentie bepaal je zelf waar de prioriteiten liggen en heb je altijd een actueel overzicht. ",
                
            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Url = "/Module/webshop",
                Title = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden.",
                
            };
            LinkDictionary[Link.MenuOver] = new LinkInfo
            {
                Name = "Over",
                Url = "/over",

                Title = "Over ons"
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie",
                
                
            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas",
                
                
            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas",
                
                
            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map",
                
                
            };
            LinkDictionary[Link.AlgemeneVoorwaarden] = new LinkInfo
            {
                Url = "/algemene-voorwaarden",
                
                
            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts",
                
                
            };
            LinkDictionary[Link.Abonnementen] = new LinkInfo
            {
                Url = "/Module/Abonnementen",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Description = "De module Hybrid SaaS Abonnementenbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige abonnementen. Met Hybrid SaaS Abonnementenbeheer loop je nooit meer achter de feiten aan."
            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Url = "/Module/certificatenbeheer",
                Title = "Eenvoudig kunnen zien wanneer een het rijbewijs of paspoort verloopt van je persooneel verloopt? Hybrid SaaS maakt het mogelijk! ",
                
            };
            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Url = "/Module/bankrekening",
                Title = "De module Bankrekeningen schept orde in de chaos. U kan eenvoudig banktransacties importeren en afletteren waardoor u altijd inzicht heeft in de openstaande en betaalde facturen.",
                
            };

            LinkDictionary[Link.BalansWinstVerliesrekening] = new LinkInfo
            {
                Url = "/Module/balans-winst-verliesrekening",
                Title = "De balans & winsten verliesrekening is een kasstroomoverzicht en daarmee een onderdeel van een jaarrekening. De balans & winst en verliesrekening geeft een overzicht van de kosten en opbrengsten van de entiteit over een bepaalde periode (meestal een jaar). ",
                
            };
            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Url = "/Module/bedrijfsagenda",
                Title = "Met de bedrijfsagenda kan je heel eenvoudig het rooster van je mederwerkers bijhouden, je kan in één opslag zien hoeveel uur een mederwerker nog heeft staan of al heeft opgenomen. ",
                
            };

            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Url = "/Module/commissciebeheer",
                Title = "Als bedrijf kan je externe bedrijven en/of personen inzetten om arbeid te verrichten. Deze diensten kan je belonen via commissie.",
                
            };
            LinkDictionary[Link.Contractenbeheer] = new LinkInfo
            {
                Url = "/Module/contractenbeheer",
                Title = "Warom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? Met Hybrid SaaS Contracten heb je nauwelijks omkijken naar je periodiek uitgaande facturen en bestellingen en zo verbeter je eenvoudig je positieve cashflow. ",
                
            };
            LinkDictionary[Link.FacturatieDebiteurbeheer] = new LinkInfo
            {
                Url = "/Module/debiteurbeheer",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk! ",
                
            };
            LinkDictionary[Link.Hrm] = new LinkInfo
            {
                Url = "/Module/human-resource-management",
                Title = "Met Hybrid SaaS Human Resource Management kun je personeelszaken eenvoudig automatiseren en heb je altijd een up-to-date inzicht in de gehele personeelsadministratie. ",
                
            };
            LinkDictionary[Link.InkoopfacturatieCrediteurenbeheer] = new LinkInfo
            {
                Url = "/inkoopfacturatie-en-crediteurenbeheer",
                
                
            };
            LinkDictionary[Link.Inkooporderbeheer] = new LinkInfo
            {
                Url = "/Module/Inkooporderbeheer",
                
                
            };
            LinkDictionary[Link.Inventarisbeheer] = new LinkInfo
            {
                Url = "/Module/inventarisbeheer",
                Title = "Uw heeft diverse objecten in uw bezit, maar geen idee waar deze zich bevinden. Laat staan dat u snel handleidingen, inkoopfacturen of serienummers kunt opzoeken. ",
                
            };
            LinkDictionary[Link.KmRegistratie] = new LinkInfo
            {
                Url = "/Module/km-registratie",
                
                
            };
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Url = "/Module/Notities",
                Title = "Met de Module Notities kan je eenvoudig een verslag bijhouden wat er is afgesproken met de klant. Je kan hem inplannen zodat hij een dag van te voren als je een afspraak heb staan weer naar voren komt.",
                
            };
            LinkDictionary[Link.OffertesOrders] = new LinkInfo
            {
                Url = "/Module/offertes-orders",
                Title = "In een handomdraai een professionele offerte opstellen en daarna vliegensvlug omzetten in een order? Dat kan! Met de module Hybrid SaaS Offertes & Orders. Eenmalig stel je een offerte lay-out op, waarna je alleen nog maar de producten of diensten als offerteregels hoeft toe te voegen. ",
                
            };
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Url = "/Module/Prepaid-kaarten",
                
                
            };
            LinkDictionary[Link.Productenbeheer] = new LinkInfo
            {
                Url = "/Module/productenbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                
            };
            LinkDictionary[Link.Projectbeheer] = new LinkInfo
            {
                Url = "/Module/Projectbeheer",
                Title = "Met de module Projectbeheer worden alle projectgegevens op één centrale plaats vastgelegd. De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven.",
                
            };
            LinkDictionary[Link.Relatiebeheer] = new LinkInfo
            {
                Url = "/Module/relatiebeheer",
                Title = "Relaties zijn de motor van iedere organisatie. Juist daarom is het belangrijk om als organisatie over een compleet en overzichtelijk CRM-systeem (Customer Relationship Management) te beschikken.",
                
            };
            LinkDictionary[Link.Tijdregistratie] = new LinkInfo
            {
                Url = "/Module/tijdregistratie",
                Title = "Het bijhouden van gewerkte uren wordt door medewerkers vaak als een tijdrovende klus beschouwd. Mede hierdoor wordt deze taak nogal eens uitgesteld en worden er achteraf dikwijls foutieve gegevens vastgelegd. ",
                
            };
            LinkDictionary[Link.Voorraadbeheer] = new LinkInfo
            {
                Url = "/Module/voorraadbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                
            };
            LinkDictionary[Link.VragenlijstenEquettes] = new LinkInfo
            {
                Url = "/Module/vragenlijsten",
                Title = "Informatie is misschien wel het belangrijkste onderdeel binnen elke organisatie. Maar hoe zorgt u ervoor dat u de juiste informatie krijgt, zonder dat er een hele papierstroom aan vooraf gaat.",
                
            };
            LinkDictionary[Link.Wachtwoordbeheer] = new LinkInfo
            {
                Url = "/Module/wachtwoordbeheer",
                Title = "Je heb zoveel verschillende website's en zoveel verschillende inloggegevens dat je het overzicht zo kwijt ben welk wachtwoord waarbij hoort. In deze module kunt u wachtwoorden registreren en koppelen aan het bedrijf zodat u altijd uw wachtwoorden bij de hand heeft.",
                
            };
            LinkDictionary[Link.Werkbonnen] = new LinkInfo
            {
                Url = "/Module/werkbonnen",
                Title = "Buitendienstmedewerkers zijn veel tijd kwijt aan het invullen van papieren werkbonnen. Waarom zou u onnodig papier en tijd verspillen, terwijl uw werkbonnen gedigitaliseerd kunnen worden. ",
                
            };
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            { //not init
                Url = "/Module/Dataopslag",
                
                
            };
            LinkDictionary[Link.Administratie] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.Alles] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.Overig] = new LinkInfo
            {//not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.GebruikerIntern] = new LinkInfo
            {//not init
                Url = "/Module/Gebruiker-intern",
                
                
            };
            LinkDictionary[Link.GebruikerExtern] = new LinkInfo
            {//not init
                Url = "/Module/Gebruiker-extern",
                
                
            };
            LinkDictionary[Link.OutlookAddIn] = new LinkInfo
            {//not init
                Url = "/Module/Outlook-Add-in",
                Title = "Door middel van de Outlook add-in krijg je de mogelijkheid om e-mails vanuit Microsoft Outlook mailbox om te zetten in tickets. Op deze manier kan je je mailbox leeg houden en sla je e-mails netjes op bij de juiste relaties en/ of projecten.",
                
            };
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Url = "/Module/facturatie",
                Title = "Een goede cashflow begint bij het op tijd versturen van je facturen. Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen. Je maakt gebruik van vooraf ingestelde gegevens. Op deze manier win je veel tijd en wordt de kans op fouten aanzienlijk verkleind. ",
                
            };
            LinkDictionary[Link.Crm] = new LinkInfo
            { //not init
                Url = "/Module/commissciebeheer",
                
                
            };
            LinkDictionary[Link.ExportExcel] = new LinkInfo
            { //not init
                Url = "/Module/Excel-export",
                
                
            };
            LinkDictionary[Link.Email] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.Extranet] = new LinkInfo
            { //not init
                Url = "/Module/Extranet",
                
                
            };
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            { //not init
                Url = "/Module/exportboekhouding",
                
                
            };
            LinkDictionary[Link.HelpDesk] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.Handleiding] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.Download] = new LinkInfo
            { //not init
                Url = "#",
                
                
            };
            LinkDictionary[Link.WordAddDownload] = new LinkInfo
            { //not init
                Url = "https://download.hybridsaas.com/install/word/setup.exe",
                
                
            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe",
                
                
            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/office/outlook/",
                
                
            };
            LinkDictionary[Link.KijkMetMijMee] = new LinkInfo
            { //not init
                Url = "http://www.kijkmetmijmee.nl/",
                
                
            };
            LinkDictionary[Link.LicentieVoorwaardenPdf] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20licentievoorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                
                
            };
            LinkDictionary[Link.AlgemeneVoorwaardenPdf] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20voorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                
                
            };
            LinkDictionary[Link.InvoerTicket] = new LinkInfo
            { //not init
                Url = "https://hybridsaas.hybridsaas.com/Extranet-revisited/Ticket/Ticket.create.asp",
                
                
            };

            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            { //not init
                Url = "/Module/Gebouwbeheer",
                
                
            };
            LinkDictionary[Link.Prognosebeheer] = new LinkInfo
            {//not init
                Url = "/Module/Prognosebeheer",
                
                
            };
            LinkDictionary[Link.Termijnstatenbeheer] = new LinkInfo
            {//not init
                Url = "/Module/Termijnstatenbeheer",
                
                
            };
            LinkDictionary[Link.Meerwerk] = new LinkInfo
            {//not init
                Url = "/Module/Meerwerk",
            };


            //lookup voor urls
            foreach ( var item in LinkDictionary.Values )
            {
                UrlDictionary[item.Url] = item;
            }
        }
    }
}