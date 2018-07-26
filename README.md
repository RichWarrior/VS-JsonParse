# VS-JsonParse

# Async
```c#
 ApiEntities.Api apiEntities = new ApiEntities.Api();
Controller.Response response = new Controller.Response(apiEntities.Borsalar);
Task<List<ResponseEntities.Exchange>> task = Task.Run(() => response.ParseJSONAsync<ResponseEntities.Exchange>());
Task.WaitAll(task);
foreach (var item in task.Result)
{
  Console.WriteLine(item.full_name+"\n"+item.buying+"\n"+item.selling);
  Console.WriteLine("--------------------------------------------------------------------------");
}
```
