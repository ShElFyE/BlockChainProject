using System.ComponentModel.DataAnnotations.Schema;

[Table("MyEntity")]  // Указываем точное имя таблицы в базе данных
public class MyEntity
{
    public int Id { get; set; }
    public string Message { get; set; }
}