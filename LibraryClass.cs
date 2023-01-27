using System;

namespace LibraryClass;

public class Revistas : Biblioteca
{
  private int _AnoPublicacao;
  private int _MesPublicacao;

  public Revistas(int AnoPublicacao, int MesPublicacao)
  {
    _MesPublicacao = MesPublicacao;
    _AnoPublicacao = AnoPublicacao;
  }

  public int MesPublicacao
  {
    get
    {
      return _MesPublicacao;
    }
    set
    {
      _MesPublicacao = value;
    }
  }

  public int AnoPublicacao
  {
    get
    {
      return _AnoPublicacao;
    }
    set
    {
      _AnoPublicacao = value;
    }
  }
}

public class Biblioteca
{
  private string _Autor;
  private string _Titulo;
  private int _Paginas;
  private bool _Status;

  public Biblioteca()
  {

  }

  public Biblioteca(string Autor, string Titulo, int Paginas, bool Status)
  {
    _Autor = Autor;
    _Titulo = Titulo;
    _Paginas = Paginas;
    _Status = Status;
  }

  public string Titulo
  {
    get
    {
      return _Titulo;
    }
    set
    {
      _Titulo = value;
    }
  }

  public string Autor
  {
    get
    {
      return _Autor;
    }
    set
    {
      _Autor = value;
    }
  }

  public int Paginas
  {
    get
    {
      return _Paginas;
    }
    set
    {
      _Paginas = value;
    }
  }

  public bool Status
  {
    get
    {
      return _Status;
    }
    set
    {
      _Status = value;
    }
  }
}