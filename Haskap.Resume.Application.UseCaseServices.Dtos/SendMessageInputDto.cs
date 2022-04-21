namespace Haskap.Resume.Application.UseCaseServices.Dtos;

public class SendMessageInputDto
{
    public string SenderName { get; set; }
    public string SenderEmailAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}
