using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RecipeTracker.Models;

namespace RecipeTracker.DAL
{
    public class RecipeTrackerInitializer : System.Data.Entity.DropCreateDatabaseAlways<RecipeTrackerContext>
    {
        protected override void Seed(RecipeTrackerContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                    LastName = "Barton",
                    FirstName = "Logan",
                    Email = "laoreet@velit.org"

                },
                new User
                {
                    UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                    LastName = "Fisher",
                    FirstName = "Ferris",
                    Email = "magnis@convalliserat.net"
                },
                new User
                {
                    UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                    LastName = "Brooks",
                    FirstName = "Phelan",
                    Email = "consequatdolor@dignissimtempor.com"
                },
                new User
                {
                    UserID = "5377F50C-7A21-C78E-0F28-22AE58BB0280",
                    LastName = "Cain",
                    FirstName = "Vivian",
                    Email = "euplacerat@Nam.edu"
                },
                new User
                {
                    UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                    LastName = "Walter",
                    FirstName = "Mohammad",
                    Email = "ultriciesadipiscing@ataugueid.com"
                }

                #region COMMENTED USERS
                /*
                 new User
                //{
                //    UserID = Guid.Parse("FEC77B29-D3C6-D0D3-C930-A4331E91390E"),
                //    LastName = "Vance",
                //    FirstName = "Rooney",
                //    Email = "tempor.bibendum.Donec@pedePraesent.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("08D096FC-1853-F8F7-88C3-C9872023B06F"),
                //    LastName = "Ramsey",
                //    FirstName = "Leilani",
                //    Email = "Nam.interdum.enim@Inornaresagittis.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("3222F55E-6184-5DED-3AE4-7CFFCA601A79"),
                //    LastName = "Gray",
                //    FirstName = "Lila",
                //    Email = "ipsum.non.arcu@amifringilla.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4E2342BC-7E15-31B3-422A-F80C1C22EBF1"),
                //    LastName = "Small",
                //    FirstName = "Celeste",
                //    Email = "ultricies.dignissim.lacus@Maurismolestie.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("7687217F-5030-CCB0-9FD8-9BDD93B34DDF"),
                //    LastName = "Mejia",
                //    FirstName = "Dale",
                //    Email = "dolor@Proinvelnisl.co.uk"
                //}
                //new User
                //{
                //    UserID = Guid.Parse("908EF336-E14F-5815-CF41-543E3A1022D5"),
                //    LastName = "Barron",
                //    FirstName = "Anika",
                //    Email = "nulla.Integer.vulputate@euismodac.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("939181B7-4C5F-48EF-3C78-FAD84D9B19A9"),
                //    LastName = "Gonzalez",
                //    FirstName = "Lionel",
                //    Email = "nulla@consequatpurusMaecenas.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("A97A2CD5-778B-9D9C-20A6-E94FEE8A8E80"),
                //    LastName = "Schneider",
                //    FirstName = "Octavius",
                //    Email = "at.sem@utodiovel.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("3AC71F5A-57AF-CF4B-D2A2-1027F7F52F00"),
                //    LastName = "Espinoza",
                //    FirstName = "Kirk",
                //    Email = "arcu@velit.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("2C6C0CBE-0F53-9AC1-5C51-7209C774B7E4"),
                //    LastName = "Ingram",
                //    FirstName = "Honorato",
                //    Email = "Integer@hendrerita.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5DB5F773-9C27-C7D3-F2CD-A43A61A31BAB"),
                //    LastName = "Pennington",
                //    FirstName = "Drew",
                //    Email = "pharetra@ligulaDonec.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("E12DB105-7606-DE14-37B3-E92E4D5E5DCC"),
                //    LastName = "Allen",
                //    FirstName = "Paul",
                //    Email = "dapibus.quam@Nuncmauris.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("A4C75EDC-CC6C-54B9-DA73-88952EB59973"),
                //    LastName = "Bray",
                //    FirstName = "Justina",
                //    Email = "Morbi@odio.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("27B7DE7D-3366-C2AD-46F4-D318AAD54FE7"),
                //    LastName = "Russo",
                //    FirstName = "Phillip",
                //    Email = "aliquam@etmagnis.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("0159A7BB-F34C-63FF-BADC-3F59FE5A99D4"),
                //    LastName = "Espinoza",
                //    FirstName = "Imelda",
                //    Email = "magna@posuerecubiliaCurae.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("8FE25A17-662D-E28B-19B2-F0798422F461"),
                //    LastName = "Duran",
                //    FirstName = "Eaton",
                //    Email = "Lorem.ipsum@sem.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("F202F7C9-9CF4-4ACE-CA23-21C48F64F97F"),
                //    LastName = "Meyer",
                //    FirstName = "Jennifer",
                //    Email = "ridiculus.mus.Proin@faucibusorciluctus.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D34C4CCC-A5FF-4257-A848-A39C98753B54"),
                //    LastName = "Soto",
                //    FirstName = "Ocean",
                //    Email = "at.pretium.aliquet@lacusQuisqueimperdiet.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("CB7F4D9F-F743-B9ED-C735-0BCE5CAEEC7D"),
                //    LastName = "Roy",
                //    FirstName = "Chandler",
                //    Email = "Nunc.ut.erat@Nunclaoreetlectus.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5FE22171-D1EF-CE71-8CB1-5A1243219C27"),
                //    LastName = "Pennington",
                //    FirstName = "Eric",
                //    Email = "purus.sapien.gravida@a.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("3A223803-1C53-C2F8-A71E-CCABD9C68E07"),
                //    LastName = "Conway",
                //    FirstName = "Lucy",
                //    Email = "Integer.vitae.nibh@luctusfelis.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("0A5C3E91-388F-0520-7881-2FE435335522"),
                //    LastName = "Avery",
                //    FirstName = "Fletcher",
                //    Email = "non.lacinia.at@justo.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("69315FB4-1923-E7D4-741B-171165924B66"),
                //    LastName = "Hutchinson",
                //    FirstName = "Thor",
                //    Email = "turpis.egestas@tinciduntadipiscing.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("506FBCC4-AE2A-B02C-9DB7-E7A96BCF4A7C"),
                //    LastName = "Clayton",
                //    FirstName = "Richard",
                //    Email = "gravida.nunc.sed@elementum.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("81FB1B91-9933-3E2B-F8C1-9A6E5DEE539B"),
                //    LastName = "Barrera",
                //    FirstName = "Odette",
                //    Email = "at@elitpharetraut.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5C62EA35-9E0E-E7AC-2BB8-65BD7C102B38"),
                //    LastName = "Hartman",
                //    FirstName = "Victoria",
                //    Email = "sem.molestie@porttitor.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4C0AAEC0-8823-4059-D3FC-C34B20469578"),
                //    LastName = "Sanchez",
                //    FirstName = "Moses",
                //    Email = "tempus@elitsedconsequat.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("2BBD6CCE-DD15-D871-E35B-DF95913F553B"),
                //    LastName = "Ford",
                //    FirstName = "Melyssa",
                //    Email = "eros.Proin@ridiculusmus.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("B2BCE0C2-8F7B-1C09-986C-ED5BEE4A515A"),
                //    LastName = "Sosa",
                //    FirstName = "Risa",
                //    Email = "Nunc.ac@Proineget.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("9B116C79-B961-61C9-894F-716BEA9BE07E"),
                //    LastName = "House",
                //    FirstName = "Quinn",
                //    Email = "placerat.Cras@nulla.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("FDF86C6E-8F94-EDD9-1801-434DFDFFFB78"),
                //    LastName = "Mcdowell",
                //    FirstName = "Nyssa",
                //    Email = "Cum.sociis@elit.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("B0392499-8F4F-F6AE-94AB-FB503C2BE192"),
                //    LastName = "Berry",
                //    FirstName = "Zelenia",
                //    Email = "vulputate.mauris.sagittis@ligula.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("E72FFD50-C7C3-F0E2-2EA6-E41D9E3CF13A"),
                //    LastName = "Trujillo",
                //    FirstName = "Brandon",
                //    Email = "diam.at@cursus.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5850DACD-A111-C074-AE19-90E25043DC48"),
                //    LastName = "Glenn",
                //    FirstName = "Kaitlin",
                //    Email = "egestas@viverraDonec.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("8B4EA799-4E37-2B48-E9B6-EB4D479D6D2D"),
                //    LastName = "Ellis",
                //    FirstName = "Nicholas",
                //    Email = "Nullam.enim@Phasellus.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("6AF69452-3609-13F4-2F8E-F14077811F4F"),
                //    LastName = "Sutton",
                //    FirstName = "Joelle",
                //    Email = "pharetra.felis.eget@erat.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("BA1D9174-C000-6542-75DD-1126D87F8305"),
                //    LastName = "Bullock",
                //    FirstName = "Hiroko",
                //    Email = "nisl.Nulla.eu@Cum.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("BC68ACB1-3233-7D54-3A89-BC32B546FA44"),
                //    LastName = "Barton",
                //    FirstName = "Kathleen",
                //    Email = "leo.elementum@rhoncus.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("C22A79E1-214E-03AC-51F5-5890C5AE7EA3"),
                //    LastName = "Hartman",
                //    FirstName = "Chadwick",
                //    Email = "Suspendisse.ac.metus@sociisnatoque.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("8F1D4BE1-E3F8-082B-E999-0A9C0CFDD579"),
                //    LastName = "Cortez",
                //    FirstName = "Kylie",
                //    Email = "dictum.eu.placerat@magnaCrasconvallis.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4CBEB35D-8544-E5CB-AC03-D131797A0B14"),
                //    LastName = "Wheeler",
                //    FirstName = "Ayanna",
                //    Email = "consequat.lectus@justo.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5BD1C46F-B9E6-406E-CC2C-A6877D413481"),
                //    LastName = "Preston",
                //    FirstName = "Keefe",
                //    Email = "orci.sem@pretiumnequeMorbi.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("0FE057FA-A599-AFCA-0406-B1A448E366C8"),
                //    LastName = "Rose",
                //    FirstName = "Kevin",
                //    Email = "lectus.justo@liberonecligula.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("0970EFC1-AE36-A7E3-9528-F5438126E981"),
                //    LastName = "Chase",
                //    FirstName = "Sylvia",
                //    Email = "Sed@Donecdignissim.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("121E272A-4861-7A8B-34B4-011AECE0D7C5"),
                //    LastName = "Booth",
                //    FirstName = "Susan",
                //    Email = "amet.orci.Ut@fringillaporttitor.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("F0274F22-039C-7F53-8D51-8362A2132F61"),
                //    LastName = "Vang",
                //    FirstName = "Dominic",
                //    Email = "ac.metus.vitae@porttitortellus.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("ACEF9405-B2E7-7D0F-03C8-17D448299EDC"),
                //    LastName = "Martinez",
                //    FirstName = "Justina",
                //    Email = "Mauris.magna.Duis@arcuVestibulumante.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("215024F7-7A9B-D252-F76D-21F1E9D935C9"),
                //    LastName = "Hunt",
                //    FirstName = "Xyla",
                //    Email = "ipsum@eu.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("68BD6C4C-6F91-D189-37F3-56744AB11F68"),
                //    LastName = "Williamson",
                //    FirstName = "Quin",
                //    Email = "Nulla.aliquet.Proin@ullamcorperDuiscursus.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("ADC35019-3C4E-6702-7879-D5574B258FCC"),
                //    LastName = "Banks",
                //    FirstName = "Keegan",
                //    Email = "volutpat.ornare@hendreritDonecporttitor.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("84542CB3-71DF-37A7-DFE5-DF4A55738349"),
                //    LastName = "Talley",
                //    FirstName = "Jael",
                //    Email = "non@Crasinterdum.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D56E97C6-B85C-8D56-3582-BB5BAEE22077"),
                //    LastName = "Holcomb",
                //    FirstName = "Arden",
                //    Email = "netus.et.malesuada@Loremipsum.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("978A36A4-2371-1F4C-F526-453545C247FE"),
                //    LastName = "Little",
                //    FirstName = "Abraham",
                //    Email = "ultrices.Duis@Praesentluctus.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("DE2509E5-9D6E-BF75-E6BF-92E6748F227E"),
                //    LastName = "Craig",
                //    FirstName = "Giselle",
                //    Email = "egestas.a.dui@dapibus.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("6955296C-89FC-32BF-505E-B50C3407EA3B"),
                //    LastName = "Kennedy",
                //    FirstName = "Hayden",
                //    Email = "id@luctusutpellentesque.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("E22C2BAF-C947-65DC-BD6C-EA6F5DDB37A3"),
                //    LastName = "Small",
                //    FirstName = "Xantha",
                //    Email = "Nullam@laciniaSed.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("B2162DB5-2726-089E-656C-57A25654525B"),
                //    LastName = "Wells",
                //    FirstName = "Russell",
                //    Email = "nunc.id.enim@semut.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("1EE37D77-3138-558A-D2FB-A03B026BC93D"),
                //    LastName = "Fry",
                //    FirstName = "Karina",
                //    Email = "lectus.rutrum@Nullam.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D0CF0AD6-065A-1EF1-3822-6FCD0E69B420"),
                //    LastName = "Foley",
                //    FirstName = "Ingrid",
                //    Email = "Nulla.tempor.augue@sempereratin.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D98F8331-B48F-940D-6066-976007AD78F0"),
                //    LastName = "Tran",
                //    FirstName = "Stephen",
                //    Email = "nec@natoquepenatibus.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("DD4FE6A8-BCB0-5FFE-C8B2-23C25515834C"),
                //    LastName = "Mcintosh",
                //    FirstName = "Hayes",
                //    Email = "in@amet.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D947B6B2-BB03-C2F4-0912-AFC93E34B7C7"),
                //    LastName = "Mckay",
                //    FirstName = "Amena",
                //    Email = "massa.Quisque@cursuset.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("8F191CEB-5776-45DF-7253-D6C26C49C751"),
                //    LastName = "Chase",
                //    FirstName = "Hop",
                //    Email = "egestas.Fusce.aliquet@Pellentesquehabitantmorbi.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("360DB27F-14F4-D64E-A798-11983EA057D6"),
                //    LastName = "Burgess",
                //    FirstName = "Serina",
                //    Email = "eget@Maurismagna.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("BD90D518-A47F-FDF8-96AF-A7BEB08F0CDA"),
                //    LastName = "Rogers",
                //    FirstName = "Basia",
                //    Email = "eu.nibh@iaculisaliquetdiam.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("3EEA555F-E093-4E1E-D90A-64516030645F"),
                //    LastName = "Whitaker",
                //    FirstName = "Risa",
                //    Email = "rutrum@arcuiaculis.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("AFF7C748-61DD-FC93-5BB4-4020595D8DF6"),
                //    LastName = "Vinson",
                //    FirstName = "Allen",
                //    Email = "lacinia.mattis@Maecenasornareegestas.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("65749378-38D8-5334-3D48-DB7A0812E086"),
                //    LastName = "Church",
                //    FirstName = "Britanni",
                //    Email = "Cras@natoquepenatibuset.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4B0D3CF7-DD13-F57E-D094-93B21FAC556C"),
                //    LastName = "Fuller",
                //    FirstName = "Celeste",
                //    Email = "eros@gravida.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("75E29410-6DAE-697D-897C-BDEB6D939964"),
                //    LastName = "Roach",
                //    FirstName = "Sacha",
                //    Email = "luctus.lobortis@Aliquamfringillacursus.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("E2F25420-C0D7-9568-D5EA-112ED711B29C"),
                //    LastName = "Campbell",
                //    FirstName = "Upton",
                //    Email = "sapien@Inornaresagittis.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("EA28E824-5FED-495F-F4AF-D4BF3B564318"),
                //    LastName = "Dotson",
                //    FirstName = "Ayanna",
                //    Email = "Mauris@necimperdietnec.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("9F6D5514-0013-82A9-9118-512EC3378752"),
                //    LastName = "Reeves",
                //    FirstName = "Hilda",
                //    Email = "massa@elementumat.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("1BE193A5-7BD1-3831-C9FD-65BC6B0C5D25"),
                //    LastName = "Lang",
                //    FirstName = "Tatyana",
                //    Email = "mi@montes.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("C34D4938-2EAD-B6FE-9CB0-C4CCE149C95D"),
                //    LastName = "Ingram",
                //    FirstName = "Davis",
                //    Email = "nisl@Namnulla.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("A3AD99CC-9AD8-192D-B818-564D8E2A1B1F"),
                //    LastName = "Albert",
                //    FirstName = "Patience",
                //    Email = "mattis.velit.justo@CurabiturmassaVestibulum.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("B18FEDEB-8274-23EB-2A04-C0A0B0E9D0FF"),
                //    LastName = "Tucker",
                //    FirstName = "Jackson",
                //    Email = "Sed.congue@pede.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("31B966E3-DB15-F20F-9060-CC8D789A78B1"),
                //    LastName = "Pierce",
                //    FirstName = "Mia",
                //    Email = "aliquam@mifelisadipiscing.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4ABC81DB-B989-FE01-2AA8-CD572FB80D9D"),
                //    LastName = "Velasquez",
                //    FirstName = "Nigel",
                //    Email = "sapien@seddolorFusce.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5DBCEF67-4D6F-7B85-279E-3E37DE9B0DC9"),
                //    LastName = "Sampson",
                //    FirstName = "Audra",
                //    Email = "neque.Sed@orciquislectus.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("3327C419-7280-E80D-364A-328A1C62BDE5"),
                //    LastName = "Lucas",
                //    FirstName = "Kelsie",
                //    Email = "porta.elit@mi.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("95E11580-A5F0-55D1-FED5-0D88D45FE88E"),
                //    LastName = "Goodwin",
                //    FirstName = "Wynter",
                //    Email = "et@enimCurabiturmassa.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("1D343810-D8F6-E195-51EE-CFBF94548FA2"),
                //    LastName = "Craft",
                //    FirstName = "Lacey",
                //    Email = "erat.eget.ipsum@Suspendisse.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("DC00596C-68D9-B82D-8497-EBAD7F9A2617"),
                //    LastName = "Medina",
                //    FirstName = "Yetta",
                //    Email = "Donec.nibh@parturientmontes.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("136A3BE9-70F1-81C1-D799-898CB1E240E4"),
                //    LastName = "Shelton",
                //    FirstName = "Harlan",
                //    Email = "metus.vitae.velit@ipsumsodalespurus.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("9B991BCF-C83F-C026-A210-AFBBE2B146BD"),
                //    LastName = "Cote",
                //    FirstName = "Dahlia",
                //    Email = "velit.Cras.lorem@consequatlectus.org"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("4B250915-3742-EF56-6449-A8EC2E2B3A11"),
                //    LastName = "Shelton",
                //    FirstName = "Ross",
                //    Email = "malesuada@dictum.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("17B26996-FC38-6974-CF69-EEE8E7973328"),
                //    LastName = "Mckee",
                //    FirstName = "Rhiannon",
                //    Email = "magna.a@pharetra.edu"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("5E596ABC-9A5B-197C-6ADB-BC2D1EE5AEC0"),
                //    LastName = "Garrison",
                //    FirstName = "Dahlia",
                //    Email = "volutpat.Nulla.facilisis@tellusNunc.ca"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("8FCDB3FE-D8B0-9050-D3A0-1CD5F187A90C"),
                //    LastName = "Best",
                //    FirstName = "Kirk",
                //    Email = "laoreet.libero.et@egestashendrerit.com"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("74B737F7-9A2E-FF62-C670-11F1256AD113"),
                //    LastName = "Ashley",
                //    FirstName = "Gareth",
                //    Email = "faucibus@tinciduntduiaugue.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("CBB8DF36-C686-9E2F-5A51-E9E88653A485"),
                //    LastName = "Bowman",
                //    FirstName = "Yolanda",
                //    Email = "consequat.dolor.vitae@nequetellusimperdiet.co.uk"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("AC8739D4-A11E-19AB-AF9E-7A3F755998D9"),
                //    LastName = "Randall",
                //    FirstName = "Liberty",
                //    Email = "eu.nibh@malesuadaaugueut.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("D7E0A1C6-6A02-2490-E3E0-57CF8ACA2F13"),
                //    LastName = "Munoz",
                //    FirstName = "Eden",
                //    Email = "Fusce@Proin.net"
                //},
                //new User
                //{
                //    UserID = Guid.Parse("EC152258-0D38-33DF-B961-82750FD48596"),
                //    LastName = "Palmer",
                //    FirstName = "Alec",
                //    Email = "nascetur@liberoduinec.edu"
                //}
                */
#endregion
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var recipes = new List<Recipe>
            {
                new Recipe{
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B"),
                  Name = "scelerisque",
                  UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                  CuisineType = CuisineType.American,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12"),
                  Name = "ligula",
                  UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                  CuisineType = CuisineType.Brazillian,
                  URL = null,
                  Rating = 4
                },

                new Recipe{
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF"),
                  Name = "Proin",
                  UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74"),
                  Name = "nunc",
                  UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                  CuisineType = CuisineType.Chinese,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE"),
                  Name = "eget",
                  UserID = "4D4EA904-75A4-6C4A-0548-5B267EC86EF5",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B"),
                  Name = "scelerisque",
                  UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                  CuisineType = CuisineType.American,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39"),
                  Name = "ligula",
                  UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                  CuisineType = CuisineType.Brazillian,
                  URL = null,
                  Rating = 4
                },

                new Recipe{
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8"),
                  Name = "Proin",
                  UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5"),
                  Name = "nunc",
                  UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                  CuisineType = CuisineType.Chinese,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4"),
                  Name = "eget",
                  UserID = "876A5096-4F91-1ABD-B634-1E22A47D9DDC",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0"),
                  Name = "scelerisque",
                  UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                  CuisineType = CuisineType.American,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6"),
                  Name = "ligula",
                  UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                  CuisineType = CuisineType.Brazillian,
                  URL = null,
                  Rating = 4
                },

                new Recipe{
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31"),
                  Name = "Proin",
                  UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084"),
                  Name = "nunc",
                  UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                  CuisineType = CuisineType.Chinese,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D"),
                  Name = "eget",
                  UserID = "699B443B-F0F7-949B-4A6B-D9BDED390C0F",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC"),
                  Name = "scelerisque",
                  UserID = "5377F50C-7A21-C78E-0F28-22AE58BB0280",
                  CuisineType = CuisineType.American,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2"),
                  Name = "ligula",
                  UserID = "5377F50C-7A21-C78E-0F28-22AE58BB0280",
                  CuisineType = CuisineType.Brazillian,
                  URL = null,
                  Rating = 4
                },

                new Recipe{
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D"),
                  Name = "Proin",
                  UserID ="5377F50C-7A21-C78E-0F28-22AE58BB0280",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984"),
                  Name = "nunc",
                  UserID ="5377F50C-7A21-C78E-0F28-22AE58BB0280",
                  CuisineType = CuisineType.Chinese,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46"),
                  Name = "eget",
                  UserID = "5377F50C-7A21-C78E-0F28-22AE58BB0280",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE"),
                  Name = "scelerisque",
                  UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                  CuisineType = CuisineType.American,
                  URL = null,
                  Rating = 3
                },

                new Recipe{
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F"),
                  Name = "ligula",
                  UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                  CuisineType = CuisineType.Brazillian,
                  URL = null,
                  Rating = 4
                },

                new Recipe{
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B"),
                  Name = "Proin",
                  UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("971F4289-631A-F341-9FDB-90F48739FF36"),
                  Name = "nunc",
                  UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                  CuisineType = CuisineType.Chinese,
                  URL = null,
                  Rating = 5
                },

                new Recipe{
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034"),
                  Name = "eget",
                  UserID = "7513E8A1-D959-E7D8-39BC-10FA98903959",
                  CuisineType = CuisineType.Cajun,
                  URL = null,
                  Rating = 3
                }

            };
            recipes.ForEach(r => context.Recipes.Add(r));
            context.SaveChanges();

            var directions = new List<Direction>
            {
                new Direction {
                  DirectionID = Guid.Parse("5EB0F31D-CDA0-AFD8-CF1E-CC1B217C15B8"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Direction {
                  DirectionID = Guid.Parse("AE3CCE59-EF63-A39D-3536-EA94807E80E0"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Direction {
                  DirectionID = Guid.Parse("DFDE092C-BDB6-6540-2BAE-2FBA5230224E"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Direction {
                  DirectionID = Guid.Parse("4B5156E6-4D3A-5AD3-E182-CFDDC423E178"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Direction {
                  DirectionID = Guid.Parse("C6D322EF-0963-7905-F45F-21A19CE1AD4D"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Direction {
                  DirectionID = Guid.Parse("BBE64087-293D-18F6-4B00-36799001836F"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Direction {
                  DirectionID = Guid.Parse("13E55028-1C51-E629-1F79-35B19C6951B7"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Direction {
                  DirectionID = Guid.Parse("5E965C73-241C-5491-BB06-38278C537409"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Direction {
                  DirectionID = Guid.Parse("6FC58BB1-337C-AAE0-73AE-4F1A14CB1447"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Direction {
                  DirectionID = Guid.Parse("9C82B985-FD4A-3EC3-D712-2F39BBD8BF24"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Direction {
                  DirectionID = Guid.Parse("F36D40EF-3422-77A2-3DD0-62C0D7322C83"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Direction {
                  DirectionID = Guid.Parse("8B210CE0-4859-1038-EF53-5448A88D8A8D"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Direction {
                  DirectionID = Guid.Parse("2E54B4F8-8CE0-5D32-D9D9-4C2A2F7D6E24"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Direction {
                  DirectionID = Guid.Parse("54C7D5AC-2DD6-D097-AC1C-69EBF3374FEE"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Direction {
                  DirectionID = Guid.Parse("0E5C6BB6-5BCF-1C7C-FEFC-85EC545B4B31"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Direction {
                  DirectionID = Guid.Parse("AAC979FC-30E5-BAAB-AE85-A95A1F521936"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Direction {
                  DirectionID = Guid.Parse("4AA5CB80-00B5-115B-CB55-E04139E7D6DC"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Direction {
                  DirectionID = Guid.Parse("39C3D8E2-E69C-1E96-9E36-92E9A49D8902"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Direction {
                  DirectionID = Guid.Parse("EE569471-36A9-D73D-C892-F3EE01D17D8C"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Direction {
                  DirectionID = Guid.Parse("57E9372A-1EC0-330B-B4B3-CD87B49F27DE"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Direction {
                  DirectionID = Guid.Parse("CA42C15B-34A6-A4BE-A608-C188F57024FB"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Direction {
                  DirectionID = Guid.Parse("6DF72EA9-CB10-568F-B0DC-B4EF20FA725A"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Direction {
                  DirectionID = Guid.Parse("1EE9E33C-8376-62EE-7E79-ADFEFC0ED117"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Direction {
                  DirectionID = Guid.Parse("7EA520BD-8CBC-6E7C-8455-2139AFBA88B9"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Direction {
                  DirectionID = Guid.Parse("D0580F80-5B3C-6B26-2998-3ACA8C7D1BCE"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Direction {
                  DirectionID = Guid.Parse("74896A16-91A0-C229-532E-A75482FA74FE"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Direction {
                  DirectionID = Guid.Parse("2A0957ED-7F8A-D9D0-200D-DEC1C895FBB0"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Direction {
                  DirectionID = Guid.Parse("3E074966-A8E8-A0FD-3B63-A7D8DE2CAAC2"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Direction {
                  DirectionID = Guid.Parse("536E0FB2-9F68-18A1-4E62-07008BF3E760"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Direction {
                  DirectionID = Guid.Parse("E37FCDE7-E3CC-8829-0CF5-811E7219EEDF"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Direction {
                  DirectionID = Guid.Parse("C00EF1F5-E7B2-C336-A793-F7A8FF2C5192"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Direction {
                  DirectionID = Guid.Parse("827BA765-EFCC-986F-8EEA-64446863A590"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Direction {
                  DirectionID = Guid.Parse("FA693C4D-3BC7-E2EC-59DC-02A82810CD0C"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Direction {
                  DirectionID = Guid.Parse("EE95E0E1-7F1A-F6C5-873B-7EAA3CCE4838"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Direction {
                  DirectionID = Guid.Parse("AF90E670-8322-F860-311D-6E565F898242"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Direction {
                  DirectionID = Guid.Parse("B09394A4-5AC1-9B3F-04F9-1BF5093F5853"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Direction {
                  DirectionID = Guid.Parse("6F645B20-7FC7-300F-D71C-28D0696AAA3F"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Direction {
                  DirectionID = Guid.Parse("9F54F27D-DB05-4B77-04F1-D7260A84A570"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Direction {
                  DirectionID = Guid.Parse("F57506B4-9712-7C13-8D64-881D6755BE61"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Direction {
                  DirectionID = Guid.Parse("07BAB119-7B83-C8B8-3A7D-6B910F81E358"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Direction {
                  DirectionID = Guid.Parse("A6BB17E8-BE78-9A1C-B42B-349EF808FF19"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Direction {
                  DirectionID = Guid.Parse("B35A4A26-D776-DEDA-7CEB-7CFB8BB79AAD"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Direction {
                  DirectionID = Guid.Parse("64CED929-EF85-257E-61F7-41591DAB63AB"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Direction {
                  DirectionID = Guid.Parse("DBE0F7AD-AA3D-E230-F166-2A3BC49B62EB"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Direction {
                  DirectionID = Guid.Parse("833BD2E6-46D4-FA6B-BED4-414BC6D4A89A"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Direction {
                  DirectionID = Guid.Parse("093CA731-616D-2C34-550A-35668F24C6EF"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Direction {
                  DirectionID = Guid.Parse("FF763FDC-B2E8-7E4B-2649-A272D8A0459F"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Direction {
                  DirectionID = Guid.Parse("412A1C13-C299-A5FC-E1D3-C6EB8A849A54"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Direction {
                  DirectionID = Guid.Parse("45AE5468-E0F2-66FD-B70D-5EB5A669F3F9"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Direction {
                  DirectionID = Guid.Parse("5737E6CA-6D83-210D-4684-9E3978CACC54"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Direction {
                  DirectionID = Guid.Parse("9E85260A-A0FF-A4A0-A9CD-756C409F2F32"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Direction {
                  DirectionID = Guid.Parse("2E0FE343-2D1D-7CC5-71CB-7C24CFA5E82B"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Direction {
                  DirectionID = Guid.Parse("3B230201-5AC7-6A33-E53F-1F69C394A23C"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Direction {
                  DirectionID = Guid.Parse("6A45D8DF-CF9E-079A-ADD8-E1D3B1E9030C"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Direction {
                  DirectionID = Guid.Parse("134ACE83-EA6C-DBAD-BD65-134D2E6C6737"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Direction {
                  DirectionID = Guid.Parse("AF4FC341-269D-B1AA-7264-CC5FA3522FBF"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Direction {
                  DirectionID = Guid.Parse("4E7EBCB2-1251-AB35-ECBB-BAF17E4EAFEB"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Direction {
                  DirectionID = Guid.Parse("9F82A1BF-355B-D498-8146-09844DAFB817"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Direction {
                  DirectionID = Guid.Parse("68A6242D-251C-A753-9D87-9D8BCA0A6B3B"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Direction {
                  DirectionID = Guid.Parse("E532A4B7-567C-9320-A2EE-1B6049476D22"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Direction {
                  DirectionID = Guid.Parse("CE97EB9D-7539-3506-66AD-868F35714816"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Direction {
                  DirectionID = Guid.Parse("1F4745AD-45D7-481C-04BB-E43F0EEF5C3B"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Direction {
                  DirectionID = Guid.Parse("BD83B325-B731-C799-E656-5B3038E70893"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Direction {
                  DirectionID = Guid.Parse("B08242A0-3F0C-4F9A-AD30-3DCC0620822B"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Direction {
                  DirectionID = Guid.Parse("DDC754BF-27A5-CE7B-05D1-857B2AA99EAC"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Direction {
                  DirectionID = Guid.Parse("DE938A55-49A6-BA20-DB37-D5C8462F08B1"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Direction {
                  DirectionID = Guid.Parse("48EEDC1C-2569-60CD-59E6-CEF1B4066DC7"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Direction {
                  DirectionID = Guid.Parse("430F8020-AD69-609F-B9C8-82DDA2193EAF"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Direction {
                  DirectionID = Guid.Parse("619E5175-3F3A-979C-911A-DBA5B4400EA8"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Direction {
                  DirectionID = Guid.Parse("5D0F70F8-F9C7-4751-AB2F-2BFB754B95E6"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Direction {
                  DirectionID = Guid.Parse("CFFA008D-6887-6F70-9CFF-AC6D139E0C17"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Direction {
                  DirectionID = Guid.Parse("1A4ACFCB-7F8F-9B95-D736-13A229A7A6D3"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Direction {
                  DirectionID = Guid.Parse("81DA174B-8D75-5CDB-E6A8-100B3AA8864C"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Direction {
                  DirectionID = Guid.Parse("77C12743-DE3C-C12D-C2D2-89EC63C164DE"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Direction {
                  DirectionID = Guid.Parse("8628C094-A8CE-A3C5-5E35-F83481F1BFAA"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Direction {
                  DirectionID = Guid.Parse("AAC892AD-0C85-248E-153D-A78733526E9E"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Direction {
                  DirectionID = Guid.Parse("D88002AD-AFF9-AB0D-5469-D29F688F9915"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Direction {
                  DirectionID = Guid.Parse("2C43CD7E-5548-7FF3-914C-7926B0F12148"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Direction {
                  DirectionID = Guid.Parse("5016C5A0-26B9-5DED-A75A-F5C184887B26"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Direction {
                  DirectionID = Guid.Parse("96C7F0FD-A4E2-59D3-325D-D1071C080FF8"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Direction {
                  DirectionID = Guid.Parse("1FD53EE4-3169-1FEE-5A1B-B046548A5608"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Direction {
                  DirectionID = Guid.Parse("33D5A4D2-B077-2395-D92C-D8F6A2F3B44F"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Direction {
                  DirectionID = Guid.Parse("0F2C40BA-5963-EE95-6D66-17D07232D8D9"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Direction {
                  DirectionID = Guid.Parse("E845C667-C611-C447-E0C8-0BA1CE3D0493"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Direction {
                  DirectionID = Guid.Parse("0E962756-C02E-239D-3273-0AC18A65931A"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Direction {
                  DirectionID = Guid.Parse("BC64F016-CD74-8B5C-2FFB-06D5E08FF0A4"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Direction {
                  DirectionID = Guid.Parse("F9FCF7EE-F2B9-0A19-966C-AE195D665BFB"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Direction {
                  DirectionID = Guid.Parse("CEFD6DA9-05B2-8B9B-6F1C-6F189206A32F"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Direction {
                  DirectionID = Guid.Parse("18BE7C94-4731-7065-EA01-E90A36C73D43"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Direction {
                  DirectionID = Guid.Parse("A941C635-F2F7-DC4B-7EE8-0041EE1E02E9"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Direction {
                  DirectionID = Guid.Parse("2BA5A4C4-E0E5-6356-EA8B-1B72267334CB"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Direction {
                  DirectionID = Guid.Parse("F48E4CCF-5633-C4F7-779C-7870B75D7F69"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Direction {
                  DirectionID = Guid.Parse("5700080C-10BF-AAE7-6409-1C6A40F4197C"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Direction {
                  DirectionID = Guid.Parse("3CE806F3-F97B-1070-A1D7-D9BC34F9E3AA"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Direction {
                  DirectionID = Guid.Parse("1C3023F2-72E9-2539-3094-74CDA8D6298A"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Direction {
                  DirectionID = Guid.Parse("02C1019F-B932-B673-99FE-42414CEE40D6"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Direction {
                  DirectionID = Guid.Parse("FAFA673E-E010-2B70-38B0-7B5997AC18B2"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Direction {
                  DirectionID = Guid.Parse("F92BF618-F97C-DE4C-A744-356C0B73693E"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Direction {
                  DirectionID = Guid.Parse("20C7BA10-90A0-9BD4-3C0B-3C280FCCE4CA"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Direction {
                  DirectionID = Guid.Parse("4508301F-1871-0EBF-5591-C9A1079699C0"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Direction {
                  DirectionID = Guid.Parse("23D73EEA-0008-855D-1AD2-A7D120944E0D"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Direction {
                  DirectionID = Guid.Parse("E1C43F9A-58C6-2068-F7CC-3984891AE050"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Direction {
                  DirectionID = Guid.Parse("636904F9-EEDE-4A68-3313-7E0A86FC9804"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Direction {
                  DirectionID = Guid.Parse("18B63797-32C0-A5A6-0ED5-DFC9BAE297BB"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Direction {
                  DirectionID = Guid.Parse("4038FE93-47AB-A9ED-DEAA-A4ED15A0A64E"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Direction {
                  DirectionID = Guid.Parse("FDB489AA-7B18-5075-0EAE-C09608B3FFF5"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Direction {
                  DirectionID = Guid.Parse("ACCBB149-755C-BF56-AE44-280C9363D081"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Direction {
                  DirectionID = Guid.Parse("0F55273F-D325-CEA5-45A7-BA956C5BBC8A"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Direction {
                  DirectionID = Guid.Parse("CC166472-3509-A121-8D9E-568A207A188B"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Direction {
                  DirectionID = Guid.Parse("2B45C09F-C54B-1753-1240-92444D579FF3"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Direction {
                  DirectionID = Guid.Parse("D23CC6CA-FFE2-F628-55D2-1B66D8241A10"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Direction {
                  DirectionID = Guid.Parse("6904BB2A-845F-109C-FCA4-C043A451409E"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Direction {
                  DirectionID = Guid.Parse("DE5515C4-E389-A82E-0652-AC1D16B44581"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Direction {
                  DirectionID = Guid.Parse("720C9D2A-6F0B-1A29-05DF-02682FC116F1"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Direction {
                  DirectionID = Guid.Parse("27E554B8-5879-7596-E3C5-ABCC104C4144"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Direction {
                  DirectionID = Guid.Parse("3894CD43-CBFC-4785-B81E-EBC3BEE9DC25"),
                  StepNum = 1,
                  Instruction = "Preheat Oven to 350 Degrees",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Direction {
                  DirectionID = Guid.Parse("E705AA64-D76D-E3EA-9873-BE109FF227EF"),
                  StepNum = 2,
                  Instruction = "Chop Up Celery and Garlic",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Direction {
                  DirectionID = Guid.Parse("384E39D1-3648-A8E8-16BA-DB0C30472675"),
                  StepNum = 3,
                  Instruction = "Saute Vegetables",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Direction {
                  DirectionID = Guid.Parse("EA8F2084-176E-71D3-253F-7638187D90EE"),
                  StepNum = 4,
                  Instruction = "Add Protein",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Direction {
                  DirectionID = Guid.Parse("1F6E66D2-87BC-D185-86B7-CD93B8BD47F8"),
                  StepNum = 5,
                  Instruction = "Stir and Serve",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },
            };
            directions.ForEach(d => context.Directions.Add(d));
            context.SaveChanges();

            var ingredients = new List<Ingredient>  {
                new Ingredient {
                  IngredientID = Guid.Parse("5EB0F31D-CDA0-AFD8-CF1E-CC1B217C15B8"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("AE3CCE59-EF63-A39D-3536-EA94807E80E0"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("DFDE092C-BDB6-6540-2BAE-2FBA5230224E"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("4B5156E6-4D3A-5AD3-E182-CFDDC423E178"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("C6D322EF-0963-7905-F45F-21A19CE1AD4D"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("9287E76B-56FA-3A7B-28BF-36BD49418C3B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("BBE64087-293D-18F6-4B00-36799001836F"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("13E55028-1C51-E629-1F79-35B19C6951B7"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("5E965C73-241C-5491-BB06-38278C537409"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("6FC58BB1-337C-AAE0-73AE-4F1A14CB1447"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("9C82B985-FD4A-3EC3-D712-2F39BBD8BF24"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("15BD9069-FB03-9FB5-43D5-E24BAD8C3A12")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("F36D40EF-3422-77A2-3DD0-62C0D7322C83"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("8B210CE0-4859-1038-EF53-5448A88D8A8D"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2E54B4F8-8CE0-5D32-D9D9-4C2A2F7D6E24"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("54C7D5AC-2DD6-D097-AC1C-69EBF3374FEE"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("0E5C6BB6-5BCF-1C7C-FEFC-85EC545B4B31"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("679904C7-DB87-833C-9743-858767176FBF")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("AAC979FC-30E5-BAAB-AE85-A95A1F521936"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("4AA5CB80-00B5-115B-CB55-E04139E7D6DC"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("39C3D8E2-E69C-1E96-9E36-92E9A49D8902"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("EE569471-36A9-D73D-C892-F3EE01D17D8C"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("57E9372A-1EC0-330B-B4B3-CD87B49F27DE"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("3C58F816-CB73-6293-98EC-B95A76226ECE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("CA42C15B-34A6-A4BE-A608-C188F57024FB"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("6DF72EA9-CB10-568F-B0DC-B4EF20FA725A"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1EE9E33C-8376-62EE-7E79-ADFEFC0ED117"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("7EA520BD-8CBC-6E7C-8455-2139AFBA88B9"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("D0580F80-5B3C-6B26-2998-3ACA8C7D1BCE"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E2AE9840-6BFA-ADE6-68A8-8333677F5A74")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("74896A16-91A0-C229-532E-A75482FA74FE"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2A0957ED-7F8A-D9D0-200D-DEC1C895FBB0"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("3E074966-A8E8-A0FD-3B63-A7D8DE2CAAC2"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("536E0FB2-9F68-18A1-4E62-07008BF3E760"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("E37FCDE7-E3CC-8829-0CF5-811E7219EEDF"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("6DCCCCE5-8486-E3F1-B8AD-1BB89D64632B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("C00EF1F5-E7B2-C336-A793-F7A8FF2C5192"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("827BA765-EFCC-986F-8EEA-64446863A590"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("FA693C4D-3BC7-E2EC-59DC-02A82810CD0C"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("EE95E0E1-7F1A-F6C5-873B-7EAA3CCE4838"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("AF90E670-8322-F860-311D-6E565F898242"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("85A19009-9DFC-A503-72E8-97B0A49C6C39")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("B09394A4-5AC1-9B3F-04F9-1BF5093F5853"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("6F645B20-7FC7-300F-D71C-28D0696AAA3F"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("9F54F27D-DB05-4B77-04F1-D7260A84A570"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("F57506B4-9712-7C13-8D64-881D6755BE61"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("07BAB119-7B83-C8B8-3A7D-6B910F81E358"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("B53207BE-A713-2840-00A1-F0C8E4614AD8")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("A6BB17E8-BE78-9A1C-B42B-349EF808FF19"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("B35A4A26-D776-DEDA-7CEB-7CFB8BB79AAD"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("64CED929-EF85-257E-61F7-41591DAB63AB"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("DBE0F7AD-AA3D-E230-F166-2A3BC49B62EB"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("833BD2E6-46D4-FA6B-BED4-414BC6D4A89A"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("554EBFAA-7B6B-D39F-5651-55519759BFD5")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("093CA731-616D-2C34-550A-35668F24C6EF"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("FF763FDC-B2E8-7E4B-2649-A272D8A0459F"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("412A1C13-C299-A5FC-E1D3-C6EB8A849A54"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("45AE5468-E0F2-66FD-B70D-5EB5A669F3F9"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("5737E6CA-6D83-210D-4684-9E3978CACC54"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("EB59888D-2F31-72A1-070C-F9FC17B55AB4")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("9E85260A-A0FF-A4A0-A9CD-756C409F2F32"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2E0FE343-2D1D-7CC5-71CB-7C24CFA5E82B"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("3B230201-5AC7-6A33-E53F-1F69C394A23C"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("6A45D8DF-CF9E-079A-ADD8-E1D3B1E9030C"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("134ACE83-EA6C-DBAD-BD65-134D2E6C6737"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("082540B5-5255-22C0-0018-A7021DA38DE0")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("AF4FC341-269D-B1AA-7264-CC5FA3522FBF"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("4E7EBCB2-1251-AB35-ECBB-BAF17E4EAFEB"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("9F82A1BF-355B-D498-8146-09844DAFB817"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("68A6242D-251C-A753-9D87-9D8BCA0A6B3B"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("E532A4B7-567C-9320-A2EE-1B6049476D22"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0D4AC180-27DC-83B9-B67E-585827BECBE6")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("CE97EB9D-7539-3506-66AD-868F35714816"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1F4745AD-45D7-481C-04BB-E43F0EEF5C3B"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("BD83B325-B731-C799-E656-5B3038E70893"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("B08242A0-3F0C-4F9A-AD30-3DCC0620822B"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("DDC754BF-27A5-CE7B-05D1-857B2AA99EAC"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("0BD3C73A-E3C2-E272-5155-423B29B28C31")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("DE938A55-49A6-BA20-DB37-D5C8462F08B1"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("48EEDC1C-2569-60CD-59E6-CEF1B4066DC7"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("430F8020-AD69-609F-B9C8-82DDA2193EAF"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("619E5175-3F3A-979C-911A-DBA5B4400EA8"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("5D0F70F8-F9C7-4751-AB2F-2BFB754B95E6"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E4A208EE-387A-4FFF-CE8C-86AE6B9B1084")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("CFFA008D-6887-6F70-9CFF-AC6D139E0C17"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1A4ACFCB-7F8F-9B95-D736-13A229A7A6D3"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("81DA174B-8D75-5CDB-E6A8-100B3AA8864C"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("77C12743-DE3C-C12D-C2D2-89EC63C164DE"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("8628C094-A8CE-A3C5-5E35-F83481F1BFAA"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7B70FE8D-F36F-52F8-803C-33EC79020D9D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("AAC892AD-0C85-248E-153D-A78733526E9E"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("D88002AD-AFF9-AB0D-5469-D29F688F9915"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2C43CD7E-5548-7FF3-914C-7926B0F12148"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("5016C5A0-26B9-5DED-A75A-F5C184887B26"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("96C7F0FD-A4E2-59D3-325D-D1071C080FF8"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("425968F2-C273-66D2-A5FB-1601FDB0E1CC")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1FD53EE4-3169-1FEE-5A1B-B046548A5608"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("33D5A4D2-B077-2395-D92C-D8F6A2F3B44F"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("0F2C40BA-5963-EE95-6D66-17D07232D8D9"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("E845C667-C611-C447-E0C8-0BA1CE3D0493"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("0E962756-C02E-239D-3273-0AC18A65931A"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("7FCEAC4F-0511-2E7A-A5FC-5323596273F2")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("BC64F016-CD74-8B5C-2FFB-06D5E08FF0A4"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("F9FCF7EE-F2B9-0A19-966C-AE195D665BFB"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("CEFD6DA9-05B2-8B9B-6F1C-6F189206A32F"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("18BE7C94-4731-7065-EA01-E90A36C73D43"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("A941C635-F2F7-DC4B-7EE8-0041EE1E02E9"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("E9454C46-42B4-E0C2-CFDE-AD3D7D3CD36D")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2BA5A4C4-E0E5-6356-EA8B-1B72267334CB"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("F48E4CCF-5633-C4F7-779C-7870B75D7F69"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("5700080C-10BF-AAE7-6409-1C6A40F4197C"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("3CE806F3-F97B-1070-A1D7-D9BC34F9E3AA"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1C3023F2-72E9-2539-3094-74CDA8D6298A"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("5A919F4E-13BF-EA61-2791-72DBAFA0D984")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("02C1019F-B932-B673-99FE-42414CEE40D6"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("FAFA673E-E010-2B70-38B0-7B5997AC18B2"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("F92BF618-F97C-DE4C-A744-356C0B73693E"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("20C7BA10-90A0-9BD4-3C0B-3C280FCCE4CA"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("4508301F-1871-0EBF-5591-C9A1079699C0"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C36D1109-AB0C-57BC-0DC2-64FF4A439A46")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("23D73EEA-0008-855D-1AD2-A7D120944E0D"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("E1C43F9A-58C6-2068-F7CC-3984891AE050"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("636904F9-EEDE-4A68-3313-7E0A86FC9804"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("18B63797-32C0-A5A6-0ED5-DFC9BAE297BB"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("4038FE93-47AB-A9ED-DEAA-A4ED15A0A64E"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("CFD088A0-996E-5F71-DAFE-13982EE314CE")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("FDB489AA-7B18-5075-0EAE-C09608B3FFF5"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("ACCBB149-755C-BF56-AE44-280C9363D081"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("0F55273F-D325-CEA5-45A7-BA956C5BBC8A"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("CC166472-3509-A121-8D9E-568A207A188B"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("2B45C09F-C54B-1753-1240-92444D579FF3"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("21D3C686-C384-0450-8993-A7974817B60F")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("D23CC6CA-FFE2-F628-55D2-1B66D8241A10"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("6904BB2A-845F-109C-FCA4-C043A451409E"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("DE5515C4-E389-A82E-0652-AC1D16B44581"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("720C9D2A-6F0B-1A29-05DF-02682FC116F1"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("27E554B8-5879-7596-E3C5-ABCC104C4144"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("C1234F92-A855-CD4D-64AA-BC867C87DD2B")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("3894CD43-CBFC-4785-B81E-EBC3BEE9DC25"),
                  Quantity = 1,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("E705AA64-D76D-E3EA-9873-BE109FF227EF"),
                  Quantity = 2,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("384E39D1-3648-A8E8-16BA-DB0C30472675"),
                  Quantity = 3,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("EA8F2084-176E-71D3-253F-7638187D90EE"),
                  Quantity = 4,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                },

                new Ingredient {
                  IngredientID = Guid.Parse("1F6E66D2-87BC-D185-86B7-CD93B8BD47F8"),
                  Quantity = 5,
                  Name = "Ingredient",
                  RecipeID = Guid.Parse("958DBD4D-2945-8B36-269B-AB260FC59034")
                }
            };
            ingredients.ForEach(i => context.Ingredients.Add(i));
            context.SaveChanges();
        }
    }
}