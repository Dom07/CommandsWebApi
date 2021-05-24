namespace CommandsWebApi.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }

        // We have removed the platform property for learning purpose. 
    }
}