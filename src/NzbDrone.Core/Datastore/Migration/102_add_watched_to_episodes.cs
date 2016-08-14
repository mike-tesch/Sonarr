using FluentMigrator;
using NzbDrone.Core.Datastore.Migration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.Datastore.Migration
{
    [Migration(102)]
    public class add_watched_to_episodes : NzbDroneMigrationBase
    {
        protected override void MainDbUpgrade()
        {
            Alter.Table("Episodes").AddColumn("Watched").AsBoolean().WithDefaultValue(false);
        }
    }
}
