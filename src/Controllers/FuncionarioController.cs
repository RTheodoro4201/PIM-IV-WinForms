using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms.Controllers
{
    public class FuncionarioController(IRepository<Funcionario> funcionarioRepository)
    {
        /*
        public async Task<IActionResult> Index()
        {
            var funcionarios = await funcionarioRepository.GetAll();
            return View(funcionarios);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                await funcionarioRepository.Add(funcionario);
                return RedirectToAction(nameof(Index));
            }

            return View(funcionario);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var funcionario = await funcionarioRepository.GetById(id);

            if (!ModelState.IsValid || funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await funcionarioRepository.Update(funcionario);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var funcionario = await funcionarioRepository.GetById(id);

            if (!ModelState.IsValid || funcionario == null)
            {
                return NotFound();
            }
            return View(funcionario);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                await funcionarioRepository.Delete(id);
            }
            return RedirectToAction(nameof(Index));
        }
        */
    }
}
