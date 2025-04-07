<h2> 📊 Exercício: Sistema de Cadastro de Livros e Autores </h2>

### Descrição
Você vai criar um banco de dados para armazenar informações sobre livros, seus autores e as editoras responsáveis pela publicação. Posteriormente, você mapeará essas tabelas para classes usando o Fluent NHibernate.

<h2>📊 Estrutura do Banco</h2>

### Autor
- Id (int, PK, identidade)
- Nome (varchar(100), not null)
- DataNascimento (date, null)

### Editora
- Id (int, PK, identidade)
- Nome (varchar(100), not null)
- Cidade (varchar(100), null)

### Livro
- Id (int, PK, identidade)
- Titulo (varchar(200), not null)
- AnoPublicacao (int, not null)
- AutorId (int, FK para Autor.Id, not null)
- EditoraId (int, FK para Editora.Id, not null)
</br>
<h2>🎯 Objetivos </h2>

- Criar as classes Autor, Editora e Livro em C#.
- Criar os mapeamentos usando Fluent NHibernate.
- Configurar o NHibernate para gerar o banco com essas tabelas (se quiser usar schema auto-generated).
- Inserir dados fictícios no banco.

#### Fazer consultas simples, como:
- Todos os livros de um determinado autor.
- Livros publicados por uma editora específica.
- Autores que nasceram antes de uma determinada data.
