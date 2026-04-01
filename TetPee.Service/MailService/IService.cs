namespace TetPee.Service.MailService;

public interface IService
{
    public Task SendMail(MailContent mailContent);
    
}
public class MailContent
{
    public required string To { get; set; } // địa chỉ gửi đến
    public required string Subject  { get; set; } // chủ đề (tiêu đề mail)
    public required string Body  { get; set; } // nooij dung hỗ trợ html của email
}