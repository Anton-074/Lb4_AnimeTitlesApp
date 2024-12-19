using System;
using System.Collections.Generic;

namespace Lb_4_AnimeTitlesApp.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOregistration { get; set; }

    //навигационное свойство

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
