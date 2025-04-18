using Microsoft.AspNetCore.Mvc;
using BitcoinMixer.Repositories;
using BitcoinMixer.Models;
using BitcoinMixer.DTOs;

namespace BitcoinMixer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepositController : ControllerBase
    {
        private readonly IDepositRepository _depositRepository;

        public DepositController(IDepositRepository depositRepository)
        {
            _depositRepository = depositRepository;
        }

        // POST: api/Deposit
        [HttpPost]
        public async Task<ActionResult<DepositReadDto>> CreateDeposit([FromBody] DepositCreateDto depositDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deposit = new Deposit
            {
                FakeBitcoinAddress = depositDto.FakeBitcoinAddress,
                Amount = depositDto.Amount,
                Status = "pending"
            };

            var createdDeposit = await _depositRepository.CreateDepositAsync(deposit);

            var depositReadDto = new DepositReadDto
            {
                Id = createdDeposit.Id,
                FakeBitcoinAddress = createdDeposit.FakeBitcoinAddress,
                Amount = createdDeposit.Amount,
                Status = createdDeposit.Status
            };

            return CreatedAtAction(nameof(GetDepositById), new { id = depositReadDto.Id }, depositReadDto);
        }

        // GET: api/Deposit/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<DepositReadDto>> GetDepositById(int id)
        {
            var deposit = await _depositRepository.GetDepositByIdAsync(id);

            if (deposit == null)
            {
                return NotFound();
            }

            var depositReadDto = new DepositReadDto
            {
                Id = deposit.Id,
                FakeBitcoinAddress = deposit.FakeBitcoinAddress,
                Amount = deposit.Amount,
                Status = deposit.Status
            };

            return Ok(depositReadDto);
        }

        // GET: api/Deposit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepositReadDto>>> GetAllDeposits()
        {
            var deposits = await _depositRepository.GetAllDepositsAsync();

            var depositDtos = deposits.Select(d => new DepositReadDto
            {
                Id = d.Id,
                FakeBitcoinAddress = d.FakeBitcoinAddress,
                Amount = d.Amount,
                Status = d.Status
            });

            return Ok(depositDtos);
        }
    }
}