using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Dashboards;

namespace DemoUmbraco.Dashboards
{
    public class RegisterUnpublishedTutorialsDashboard : IDashboard
    {
        public string[] Sections => new[] { Constants.Applications.Content, "myCustomSection" };

        public IAccessRule[] AccessRules
        {
            get
            {
                var rules = new IAccessRule[]
                {
                    new AccessRule {Type = AccessRuleType.Grant, Value = Constants.Security.EditorGroupAlias}
                };
                return rules;
            }
        }

        public string Alias => "UnpublishedTutorials";

        public string View => "/umbraco/backoffice/Plugins/Admin/UnpublishedTutorials";
    }
}
