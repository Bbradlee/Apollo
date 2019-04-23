using System.Collections.Generic;
namespace SportsStore.Models
{
    public static class Repository
    {
        private static List<Polling> responses = new List<Polling>();
        public static IEnumerable<Polling> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(Polling response)
        {
            responses.Add(response);
        }
    }
}