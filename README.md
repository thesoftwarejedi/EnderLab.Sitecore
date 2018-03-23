# R2Integrated.Sitecore.NewRelicInstrumentation

Adds NewRelic Instrumentation to Sitecore

New Relic alone is not useful for Sitecore applications because it fails to understand how to track individual items and renderings.  It will show everything as /SitecoreController/Index which is not useful at all.

By adding this simple plugin to your Sitecore instance, your New Relic will instead use the item's "Template Name" as the transaction name (but still maintain the URL in the details), and will also instrument every rendering for reporting and exploring within Insights.

Screenshots below.

## Template Names As Transactions:
![Template Names As Transactions](http://prntscr.com/ivi36l)

## Sitecore Metadata Stored On Transactions:
![Sitecore Metadata Stored On Transactions](http://prntscr.com/ivi4wv)

## Metrics Captured For Every Rendering:
![Metrics Captured For Every Rendering](http://prntscr.com/ivi5ho)

