namespace Student2
{
    public class Class1
    {
        /// <summary>
        /// Klasse som beskriver en studerende via navn og adresse.
        /// </summary>
            public string Adresse { get; set; }
            public string Navn { get; set; }

            public Class1(string adresse, string navn)
            {
                Adresse = adresse;
                Navn = navn;
            }
            /// <summary>
            /// Metode som bruger navn og adresse til at returenere en string bestående af de to variabler.
            /// </summary>
            /// <param name="adresse"></param>
            /// <param name="navn"></param>
            /// <returns>"Den studerendes navn er:" + navn + ". Den studerendes adresse er "+ adresse + "."</returns>
            public string ReturnNavnOgAdresse()
            {
                string navnOgAdresse = "Den studerendes navn er: " + Navn + ". Den studerendes adresse er " + Adresse + ".";
                return navnOgAdresse;
            }

        
    }
}