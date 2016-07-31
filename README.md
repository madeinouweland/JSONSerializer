This is the interesting part:
https://github.com/madeinouweland/JSONSerializer/blob/master/JSONSerializingNative/JSONSerializer.cs

## Deserialize

```
var json = "{\"Employees\":[{\"Age\":35,\"Name\":\"Vera\"},{\"Age\":41,\"Name\":\"Chuck\"},{\"Age\":26,\"Name\":\"Dave\"}],\"Name\":\"Toverstudio\"}";
var serializer = new JSONSerializer<Company>();
var company = serializer.Deserialize(json);
```

## serializer

```
var json2 = serializer.Serialize(company);
Debug.WriteLine(json2);
```
