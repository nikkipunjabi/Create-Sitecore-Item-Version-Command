using Sitecore.Data.Items;
using Sitecore.Shell.Framework.Commands;

namespace Sitecore.SharedSource.CreateItemCommand
{
    public class Command : Sitecore.Shell.Framework.Commands.Command
    {
        public override void Execute(CommandContext context)
        {
            if (context.Items != null && context.Items.Length > 0)
            {
                Item contextItem = context.Items[0];
                if (contextItem != null)
                {
                    contextItem.Versions.AddVersion();
                    Context.ClientPage.SendMessage(this, string.Format("item:load(id={0})", (object)contextItem.ID));
                }
            }
        }
    }
}
