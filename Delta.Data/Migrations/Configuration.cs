namespace Delta.Data.Migrations
{
    using Delta.Shared.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Delta.Data.DeltaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Delta.Data.DeltaContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Organisations.AddOrUpdate(
                o => o.Name,
                new Organisation { Name = "The Abcists" },
                new Organisation { Name = "Hellriders" },
                new Organisation { Name = "Drunkards" }
            );

            context.Characters.AddOrUpdate(
                c => c.Name,
                new Character { Name = "Gershel Parasyuk", Organisation = context.Organisations.First(o => o.Name == "The Abcists") },
                new Character { Name = "Khaym Bond", Organisation = context.Organisations.First(o => o.Name == "The Abcists") },
                new Character { Name = "John Smith", Organisation = context.Organisations.First(o => o.Name == "Hellriders") },
                new Character { Name = "Negoro", Organisation = context.Organisations.First(o => o.Name == "Hellriders") },
                new Character { Name = "Hose Windoza", Organisation = context.Organisations.First(o => o.Name == "The Abcists") },
                new Character { Name = "DJ Arbouze", Organisation = null },
                new Character { Name = "Gosha, the first twin", Organisation = context.Organisations.First(o => o.Name == "Drunkards") },
                new Character { Name = "Gosha, the second twin", Organisation = context.Organisations.First(o => o.Name == "Drunkards") },
                new Character { Name = "Nikolay Ivanovitch", Organisation = context.Organisations.First(o => o.Name == "Drunkards") },
                new Character { Name = "Timidean the Fiest", Organisation = null },
                new Character { Name = "Peter Sidoroff", Organisation = null },
                new Character { Name = "Duke Peace", Organisation = context.Organisations.First(o => o.Name == "Drunkards") },
                new Character { Name = "Heythere", Organisation = context.Organisations.First(o => o.Name == "The Abcists") },
                new Character { Name = "Mandatory disabled woman character", Organisation = context.Organisations.First(o => o.Name == "The Abcists") },
                new Character { Name = "Mandatory gay nigger character", Organisation = context.Organisations.First(o => o.Name == "The Abcists") }
            );
        }
    }
}
