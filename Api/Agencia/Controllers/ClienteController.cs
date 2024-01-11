using Agencia.Model;
using Agencia.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ClienteController : ControllerBase
  {

    private readonly DataContext _dataContext;


    public ClienteController(DataContext dataContext)
    {
      _dataContext = dataContext;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
    {
      return await _dataContext.Cliente.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Cliente>> GetClienteById(int id)
    {
      var cliente = await _dataContext.Cliente.FindAsync(id);
      if (cliente == null)
      {
        return NotFound();
      }

      return Ok(cliente);
    }





  }

}

//   [ApiController]
//   [Route("api/[controller]")]

//   public class ClienteController : ControllerBase
//   {
//     private readonly DataContext _dataContext;


//     public ClienteController(DataContext dataContext)
//     {
//       _dataContext = dataContext;
//     }

//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
//     {
//       return await _dataContext.Clientes.ToListAsync();
//     }

//     //GET: api/Destino/5
//   [HttpGet("{id}")]
//     public async Task<ActionResult<Cliente>> GetCliente(int id)
//     {
//       var cliente = await _context.Cliente.FindAsync(id);

//       if (cliente == null)
//       {
//         return NotFound();
//       }

//       return cliente;
//     }

//     [HttpGet]
//     public async Task<ActionResult<List<ClienteModel>>> BuscarTodosUsuarios()
//     {
//       List<ClienteModel> clientes = await _clienteRepositorio.BuscarTodosClientes();
//       return Ok(clientes);
//     }

//     [HttpGet("{id}")]
//     public async Task<ActionResult<ClienteModel>> BuscarPorId(int id)
//     {
//       ClienteModel cliente = await _clienteRepositorio.BuscarPorId(id);
//       return Ok(cliente);
//     }

//     [HttpPost]
//     public async Task<ActionResult<ClienteModel>> Cadastrar([FromBody] ClienteModel clienteModel)
//     {
//       ClienteModel cliente = await _clienterepositorio.Adicionar(clienteModel);

//       return Ok(cliente);
//     }

//     [HttpPut("{id}")]
//     public async Task<ActionResult<ClienteModel>> Atualizar([FromBody] ClienteModel clienteModel, int id)
//     {
//       clienteModel.Id = id;
//       ClienteModel cliente = await _clienteRepositorio.Atualizar(clienteModel, id);

//       return Ok(cliente);
//     }

//     [HttpDelete("{id}")]
//     public async Task<ActionResult<UsuarioModel>> Apagar(int id)
//     {

//       bool apagado = await _usuarioRepositorio.Apagar(id);

//       return Ok(apagado);




//     }
//   }
// }

// using Clientes.Data;
// using Clientes.Model;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace Clientes.Controllers
// {
//   [ApiController]
//   [Route("api/[controller]")]
//   public class ClienteController : ControllerBase
//   {
//     private readonly DataContext _dataContext;

//     public ClienteController(DataContext dataContext)
//     {
//       _dataContext = dataContext;
//     }

//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
//     {
//       return await _dataContext.Clientes.ToListAsync();
//     }

//     [HttpGet("{id}")]
//     public async Task<ActionResult<Cliente>> GetClienteById(int id)
//     {
//       var cliente = await _dataContext.Clientes.FindAsync(id);
//       if (cliente == null)
//       {
//         return NotFound();
//       }

//       return Ok(cliente);
//     }
//   }
// }


