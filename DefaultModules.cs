using System.Collections.Generic;

namespace WebApplication1
{
    public class DefaultModules
    {
        public enum ModuleList
        {
            Abonnementen,
            BalansWinstVerliesrekening,
            Bankrekening,
            Bedrijfsagenda,
            Relatiebeheer,
            Facturatie,
            ExportNaarExternBoekhouding,
            Notities,
            Gebruiker,
            Dataopslag,
            Ticketsysteem,
        };

        public enum PakketList
        {
            ticketFacturatie,
        };

        public static class ModulesList
        {
            public class Pakket
            {
                public List<ModuleList> Modules = new List<ModuleList>();
            }

            static Dictionary<PakketList, Pakket> moduleDictionary = new Dictionary<PakketList, Pakket>();

            static ModulesList()
            {
                moduleDictionary[PakketList.ticketFacturatie] = new Pakket
                {
                    Modules = new List<ModuleList>
                    {
                        ModuleList.Relatiebeheer,
                        ModuleList.Ticketsysteem,

                    }
                };
            }

            public static List<ModuleList> GetModule(PakketList link)
            {
                return moduleDictionary[link].Modules;
            }
        }
    }
}