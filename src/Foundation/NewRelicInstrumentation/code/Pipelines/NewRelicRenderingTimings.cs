using Sitecore.Pipelines.HttpRequest;

namespace R2Integrated.Foundation.NewRelicInstrumentation
{
    public class NewRelicRecordStatistic : Sitecore.Mvc.Pipelines.Response.RenderRendering.RecordStatistic
    {
        protected override void AddStatistic(string traceName, double elapsed, long itemsAccessed, bool usedCache)
        {
            base.AddStatistic(traceName, elapsed, itemsAccessed, usedCache);
            NewRelic.Api.Agent.NewRelic.RecordResponseTimeMetric("Custom/" + traceName, (long)elapsed);
        }
    }
}