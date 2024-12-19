using System;
using System.Collections.Generic;

namespace Lb_4_AnimeTitlesApp.Models;

public partial class AnimeType
{
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    //навигационное свойство

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
