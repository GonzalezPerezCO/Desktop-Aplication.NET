using System;

public class Estudiante
{

    public string name { get; set; }
    public string lastname { get; set; }
    public int code { get; set; }
    public string career { get; set; }
    public int semester { get; set; }
    public bool enabled { get; set; }

    public string horario { get; set; }
    public int fallas { get; set; }
    public string obervaciones { get; set; }
    public Estudiante()
	{
	}

    public Estudiante(string name, string lastname, int code, string career, int semester, bool enabled)        
    {
        this.name = name;
        this.lastname = lastname;
        this.code = code;
        this.career = career;
        this.semester = semester;
        this.enabled = enabled;
    }

    


}
