using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hybrid_Saas
{
    public enum Link
    {
        Commisie,
        TicketSysteem,
        Contact,
        Factsheet, 
        Financieel,
        Index,
        Module,
        Molules,
        PakketContactbeheer,
        PakketOfferteVoorraad,
        PakketTicketsFacturatie,
        Pakketten,
        ReleaseNotes,
        Support,
        Webshop,
        Over,
        Blog,
        Youtube,
        Twitter,
        Facebook,
        SiteMap,
        AlgemeeneVoorwaarde,
        GooglePlus,
        lol,
		Abonnementen,
        Certificatenbeheer,
        Bankrekening,
        BalansWinstVerliesrekening,
        Bedrijfsagenda,
        Commissiebeheer,
        Contractenbeheer,
        FacturatieDebiteurbeheer,
        HRM,
        InkoopfacturatieCrediteurenbeheer,
        Inkooporderbeheer,
        Inventarisbeheer,
        KmRegistratie,
        Notities,
        OffertesOrders,
        Prepaidkaarten,
        Productenbeheer,
        Projectbeheer,
        Relatiebeheer,
        Tijdregistratie,
        Voorraadbeheer,
        VragenlijstenEquettes,
        Wachtwoordbeheer,
        Werkbonnen,
        Dataopslag,
        Administratie,
        Alles,
        Overig,
        Gebruiker,
        OutlookAddIn,
        Facturatie,
        CRM,
        ExportExcel,
        Email,
        Extranet,
        ExportExternPakket,
        ExportBoekhouding,    
        Download,
        HelpDesk,
        Handleiding,
        BrowserDownload,
        WordAddDownload,
        OutlookAddDownload,
        KijkMetMijMee,
        LicentievoorwaardenPDF,
        AlgemeeneVoorwaardePDF,
        InvoerTicket,
        Gebouwbeheer,
        MeestGesteldeVragen,
    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Url;
        }

        static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();

        static LinkList()
        {
            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "/Meest-gestelde-vragen"
            };
            LinkDictionary[Link.Commisie] = new LinkInfo
            {
                Url = "/Commissie"
            };
            LinkDictionary[Link.Contact] = new LinkInfo
            {
                Url = "/contact"
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet"
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Url = "/Financieel"
            };
            LinkDictionary[Link.Index] = new LinkInfo
            {
                Url = "/index"
            };
            LinkDictionary[Link.Module] = new LinkInfo
            {
                Url = "/modules"
            };
            LinkDictionary[Link.Molules] = new LinkInfo
            {
                Url = "/module"
            };
            LinkDictionary[Link.PakketContactbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer"
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad"
            };
            LinkDictionary[Link.Pakketten] = new LinkInfo
            {
                Url = "/pakketten"
            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie"
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Url = "http://www.hybridsaas.com/release-notes"
            };
            LinkDictionary[Link.Support] = new LinkInfo
            {
                Url = "/support"
            };
            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Url = "/Module/ticket-systeem"
            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Url = "/Module/webshop"
            };
            LinkDictionary[Link.Over] = new LinkInfo
            {
                Url = "/over"
            };
            LinkDictionary[Link.Blog] = new LinkInfo
            {
                Url = "/blog"
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie"
            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas"
            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas"
            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map"
            };
            LinkDictionary[Link.AlgemeeneVoorwaarde] = new LinkInfo
            {
                Url = "/algemeene-voorwaarde"
            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts"
            };
            LinkDictionary[Link.Abonnementen] = new LinkInfo
            {
                Url = "/Module/Abonnementen"
            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Url = "/Module/certificatenbeheer"
            };
            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Url = "/Module/bankrekening"
            };

            LinkDictionary[Link.BalansWinstVerliesrekening] = new LinkInfo
            {
                Url = "/Module/balans-winst-verliesrekening"
            }; 
            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Url = "/Module/bedrijfsagenda"
            }; 
            
            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Url = "/Module/commissciebeheer"
            }; 
            LinkDictionary[Link.Contractenbeheer] = new LinkInfo
            {
                Url = "/pakket-contactbeheer"
            }; 
            LinkDictionary[Link.FacturatieDebiteurbeheer] = new LinkInfo
            {
                Url = "/Module/facturatie-debiteurbeheer"
            }; 
            LinkDictionary[Link.HRM] = new LinkInfo
            {
                Url = "/Module/human-resource-management"
            }; 
            LinkDictionary[Link.InkoopfacturatieCrediteurenbeheer] = new LinkInfo
            {
                Url = "/inkoopfacturatie-en-crediteurenbeheer"
            }; 
            LinkDictionary[Link.Inkooporderbeheer] = new LinkInfo
            {
                Url = "/Module/inkooporderbeheer"
            }; 
            LinkDictionary[Link.Inventarisbeheer] = new LinkInfo
            {
                Url = "/Module/inventarisbeheer"
            }; 
            LinkDictionary[Link.KmRegistratie] = new LinkInfo
            {
                Url = "/Module/km-registratie"
            }; 
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Url = "/Module/Notities"
            }; 
            LinkDictionary[Link.OffertesOrders] = new LinkInfo
            {
                Url = "/Module/offertes-orders"
            }; 
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Url = "/Module/Prepaid-kaarten"
            }; 
            LinkDictionary[Link.Productenbeheer] = new LinkInfo
            {
                Url = "/Module/productenbeheer"
            }; 
            LinkDictionary[Link.Projectbeheer] = new LinkInfo
            {
                Url = "/Module/Projectbeheer"
            }; 
            LinkDictionary[Link.Relatiebeheer] = new LinkInfo
            {
                Url = "/Module/relatiebeheer"
            }; 
            LinkDictionary[Link.Tijdregistratie] = new LinkInfo
            {
                Url = "/Module/tijdregistratie"
            }; 
            LinkDictionary[Link.Voorraadbeheer] = new LinkInfo
            {
                Url = "/Module/voorraadbeheer"
            }; 
            LinkDictionary[Link.VragenlijstenEquettes] = new LinkInfo
            {
                Url = "/Module/vragenlijsten"
            }; 
            LinkDictionary[Link.Wachtwoordbeheer] = new LinkInfo
            {
                Url = "/Module/wachtwoordbeheer"
            }; 
            LinkDictionary[Link.Werkbonnen] = new LinkInfo
            {
                Url = "/Module/werkbonnen"
            }; 
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            { //not init
                Url = "/Module/Dataopslag"
            }; 
            LinkDictionary[Link.Administratie] = new LinkInfo
            { //not init
                Url = "#"
            }; 
            LinkDictionary[Link.Alles] = new LinkInfo
            { //not init
                Url = "#"
            }; 
            LinkDictionary[Link.Overig] = new LinkInfo
            {//not init
                Url = "#"
            }; 
            LinkDictionary[Link.Gebruiker] = new LinkInfo
            {//not init
                Url = "/Module/Gebruiker"
            }; 
            LinkDictionary[Link.OutlookAddIn] = new LinkInfo
            {//not init
                Url = "/Module/Outlook-Add-in"
            }; 
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Url = "/Module/facturatie-debiteurbeheer"
            }; 
            LinkDictionary[Link.CRM] = new LinkInfo
            { //not init
                Url = "/Module/commissciebeheer"
            }; 
            LinkDictionary[Link.ExportExcel] = new LinkInfo
            { //not init
                Url = "/Module/Excel-export"
            }; 
            LinkDictionary[Link.Email] = new LinkInfo
            { //not init
                Url = "#"
            }; 
            LinkDictionary[Link.Extranet] = new LinkInfo
            { //not init
                Url = "/Module/Extranet"
            }; 
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            { //not init
                Url = "#"
            };
            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            { //not init
                Url = "/Modules/ExportBoekhouding"
            };
            LinkDictionary[Link.HelpDesk] = new LinkInfo
            { //not init
                Url = "#"
            };
            LinkDictionary[Link.Handleiding] = new LinkInfo
            { //not init
                Url = "#"
            };
            LinkDictionary[Link.Download] = new LinkInfo
            { //not init
                Url = "#"
            };
            LinkDictionary[Link.WordAddDownload] = new LinkInfo
            { //not init
                Url = "https://download.hybridsaas.com/install/word/setup.exe"
            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe"
            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/office/outlook/"
            };
            LinkDictionary[Link.KijkMetMijMee] = new LinkInfo
            { //not init
                Url = "http://www.kijkmetmijmee.nl/"
            };
            LinkDictionary[Link.LicentievoorwaardenPDF] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20licentievoorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf"
            };
            LinkDictionary[Link.AlgemeeneVoorwaardePDF] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20voorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf"
            };
            LinkDictionary[Link.InvoerTicket] = new LinkInfo
            { //not init
                Url = "https://hybridsaas.hybridsaas.com/Extranet-revisited/Ticket/Ticket.create.asp"
            };

            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            { //not init
                Url = "/Module/Gebouwbeheer"
            };
            foreach (var foo in Enum.GetValues(typeof(Link)))
            {
                if (!LinkDictionary.ContainsKey((Link)foo))
                {
                    LinkDictionary[(Link)foo] = new LinkInfo
                    { //not init
                        Url = "#"
                    };
                }
            }
        }

        public static string GetLink(Link link)
        {
            return LinkDictionary[link].Url;
        }
    }
}