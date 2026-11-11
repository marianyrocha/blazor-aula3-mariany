- Responda em 3 a 5 linhas: por que o FormProduto não adiciona o produto direto
na lista? Quem faz isso, e como ele fica sabendo que precisa fazer?

O FormProduto não adiciona os produtos diretamente na lista porque a ela foi criada na página Produtos.razor, 
a lista não existe no FormProduto.razor. Portanto, Produtos.razor é responsável por fazer isso e quem permite 
que essa communication aconteça é o EventCallback. Ao preencher o formulário corretamente e clicar no botão 
Adicionar Produto, o FormProduto aciona o EventCallback e a página executa o método AdicionarProduto, assim, o 
produto é adicionado a lista. 

