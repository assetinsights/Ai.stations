# Asset Insights c# Stations coding challenge

## Task

Using the code in the repo, we would like you to refactor it to deliver the following:

- Return all the `features` from the example GEOJson via the RESTful Api. The example GEOJson is located in `Data/stations.json` . There should be a route called `api/stations` in `StationsController.cs` that you can return the json from.
- Return one `feature` in example GEOJson via the RESTful Api. The `feature` that should be returned should be based on the `title` (which you will see in the GEOJson properties) that is passed into the GET request. The example GEOJson is located in `Data/stations.json`. There should be a route called `api/station` in `StationsController.cs` that you can return the json from. 

NICE TO HAVE (Only if time permits):
- Apply unit testing (You can use your prefered testing tool I.E nUnit/xUnit)

Note:
A class model has been provided for you called GeoModel.cs which does match the data structure in `Data/stations.json` to save you time.

Last bit of advice:
Feel free to completely tear the whole code/solution apart. Don't feel like you can't edit any of it :). Any questions about the test please do not hesitate to contact joe.fradley@assetinsights.co.uk

Good Luck!
