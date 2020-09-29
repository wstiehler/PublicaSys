Nesta Build contém:

	Bibliotecas:
		Data
			Database
				PublicaSysDatabase.mdf
			Migrations
			Context
				PublicaSysContext
			Repository
		ConsoleApp
		Domain
			Entities 
  				Base
				Tabela	
			Interface
				IRepository
				IService
		WindowsForm
			FormInicio //Pai
				Consultas
					FormConsultarDados
					FormInserirDados
				Tabelas
					FormTabelaJogos
				Calculos 
					Calculo Da tempora
						FormCalculoMin
						FormCalculoMax
						
				Informações
					
				
			
	Referencias:
		Referencia na Biblioteca PublicaSys.Data, referenciando as demais bibliotecas. 

	Banco de dados:

		PublicaSysDatabase 
			Carregado com a tabela
				Tabela contém: ID/Jogo/Placas/MinimoTemp/MaximoTemp/QuebraRecordeMin/QuebraRecordeMax.
	
		Banco de dados foi utlizado com base no  EntityFramework.6.4.4
		
		Incluido o banco de dados no Gerenciador de Servidores. 
		
		Banco Ativo
		
		Banco Alimentado. 

		Forms Finalizado

		Codigo Finalizado 
		

Adicionado indentação 