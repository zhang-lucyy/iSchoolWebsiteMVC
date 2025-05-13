namespace P3.Services
{
    public class DataRetrieval
    {
        // task vs thread
        // task has async wait and a return value!
        // no direct way to return from a thread
        // task can do multipole things at once, thread can do one
        // can cancel a task
        // task is a higher level concept than a thread

        // d is something like 'about/' or 'people/' - the endpoint
        public async Task<string> GetData(string d)
        {
            // using statement - at the end of it automatically calls dispose method
            using (var client = new HttpClient())
            {
                // set up
                client.BaseAddress = new Uri("https://ischool.gccis.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applications/json"));

                // try catch
                try
                {
                    HttpResponseMessage res = await client.GetAsync(d, HttpCompletionOption.ResponseHeadersRead);
                    res.EnsureSuccessStatusCode();
                    // go get it
                    var data = await res.Content.ReadAsStringAsync();
                    // at this point, data is just a string...
                    return data;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    return "HTTPReq: " + msg;
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    return "Ex: " + msg;

                }
                
            }
        }
    }
}
