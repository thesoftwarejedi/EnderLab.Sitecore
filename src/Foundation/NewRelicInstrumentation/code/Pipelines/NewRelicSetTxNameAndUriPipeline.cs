using Sitecore.Pipelines.HttpRequest;

namespace R2Integrated.Foundation.NewRelicInstrumentation
{
    public class NewRelicSetTxNameAndUriPipeline
    {
        public void Process(HttpRequestArgs args)
        {
            NewRelic.Api.Agent.NewRelic.SetTransactionUri(args.RequestUrl);
            NewRelic.Api.Agent.NewRelic.SetTransactionName("Sitecore Request", Sitecore.Context.Item?.TemplateName ?? "Unknown");
            if (Sitecore.Context.Item != null)
            {
                NewRelic.Api.Agent.NewRelic.AddCustomParameter("Sitecore Item Name", Sitecore.Context.Item.Name);
                NewRelic.Api.Agent.NewRelic.AddCustomParameter("Sitecore Item Id", Sitecore.Context.Item.ID?.ToString());
                NewRelic.Api.Agent.NewRelic.AddCustomParameter("Sitecore Item Path", Sitecore.Context.Item.Paths?.Path?.ToString());
            }
            return;
        }
    }
}
