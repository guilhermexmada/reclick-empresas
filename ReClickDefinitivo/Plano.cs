using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReClickDefinitivo
{
    class Plano
    {
        private static string nome;
        private static string email;
        private static string cnpj;
        private static string razao_social;
        private static string telefone;
        private static string cep;
        private static string uf;
        private static string municipio;
        private static string usuarios;
        private static string responsavel_legal;
        private static string responsavel_pgrs;
        private static string data;
        private static string descricao;
        private static string descricao_calculo;
        private static string descricao_projetos;
        private static string coleta_reciclaveis;
        private static string coleta_rejeitos;
        private static string coleta_perigosos;
        private static string coleta_organicos;
        private static string destino_final;
        private static string descricao_destino_final;
        private static string recolhimento;
        private static string responsavel;
        private static string dados_responsavel;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string Razao_social
        {
            get
            {
                return razao_social;
            }

            set
            {
                razao_social = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }

        public string Responsavel_legal
        {
            get
            {
                return responsavel_legal;
            }

            set
            {
                responsavel_legal = value;
            }
        }

        public string Responsavel_pgrs
        {
            get
            {
                return responsavel_pgrs;
            }

            set
            {
                responsavel_pgrs = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Descricao_calculo
        {
            get
            {
                return descricao_calculo;
            }

            set
            {
                descricao_calculo = value;
            }
        }

        public string Descricao_projetos
        {
            get
            {
                return descricao_projetos;
            }

            set
            {
                descricao_projetos = value;
            }
        }

        public string Coleta_reciclaveis
        {
            get
            {
                return coleta_reciclaveis;
            }

            set
            {
                coleta_reciclaveis = value;
            }
        }

        public string Coleta_rejeitos
        {
            get
            {
                return coleta_rejeitos;
            }

            set
            {
                coleta_rejeitos = value;
            }
        }

        public string Coleta_perigosos
        {
            get
            {
                return coleta_perigosos;
            }

            set
            {
                coleta_perigosos = value;
            }
        }

        public string Coleta_organicos
        {
            get
            {
                return coleta_organicos;
            }

            set
            {
                coleta_organicos = value;
            }
        }

        public string Destino_final
        {
            get
            {
                return destino_final;
            }

            set
            {
                destino_final = value;
            }
        }

        public string Descricao_destino_final
        {
            get
            {
                return descricao_destino_final;
            }

            set
            {
                descricao_destino_final = value;
            }
        }

        public string Recolhimento
        {
            get
            {
                return recolhimento;
            }

            set
            {
                recolhimento = value;
            }
        }

        public string Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }

        public string Dados_responsavel
        {
            get
            {
                return dados_responsavel;
            }

            set
            {
                dados_responsavel = value;
            }
        }
        //função que retorna dados organizados para gerar o pdf
        public string Registrar_Plano()
        {
            return
                "Nome: " + this.Nome + "\n Email: " + this.Email + "\n Telefone: " + this.Telefone + "\n Cnpj: " + this.Cnpj + 
                "\n CEP: " + this.Cep + "\n Município: " + this.Municipio + "\n UF: " + this.Uf + "\n Razão social: " + this.Razao_social +
                "\n Usuários: " + this.Usuarios + "\n Responsável legal: " + this.Responsavel_legal + "\n Responsável pelo PGRS: " + this.Responsavel_pgrs +
                "\n Data de documentação: " + this.Data + "\n Descrição da atividade: " + this.Descricao;
        }

    }
}
