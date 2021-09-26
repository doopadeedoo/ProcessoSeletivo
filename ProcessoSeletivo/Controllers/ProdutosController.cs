﻿using Microsoft.AspNetCore.Mvc;
using ProcessoSeletivo.Services;
using ProcessoSeletivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoSeletivo.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController (ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public IActionResult Index()
        {
            var list = _produtoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            _produtoService.Insert(produto);
            return RedirectToAction(nameof(Index));
        }
    }
}
