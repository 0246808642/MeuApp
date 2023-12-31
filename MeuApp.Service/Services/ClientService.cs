﻿using MeuApp.Domain.Entity;
using MeuApp.Domain.Enum;
using MeuApp.Domain.Interfaces.Repository;
using MeuApp.Domain.Interfaces.Service;
using System.Data;
using System.Linq.Expressions;

namespace MeuApp.Service.Services
{

    public class ClientService : IClientService
    {
        private readonly IClientRepository _vIClientRepository;

        public ClientService(IClientRepository _pIClientRepository)
        {
            _vIClientRepository = _pIClientRepository;
        }

        public async Task<Client> Add(Client entity)
        {
            var result = await _vIClientRepository.Add(entity); 
            return result;
        }

        public async Task AddRange(IList<Client> entity)
        {
            await _vIClientRepository.AddRange(entity); 
        }

        public async Task<Client> Delete(long id)
        {
            var result = await _vIClientRepository.Delete(id);
            return result;
        }

        public Client Get(Func<Client, bool> predicate) 
        {
            var result = _vIClientRepository.Get(predicate);
            return result;
        }

        public IQueryable<Client> GetAll(Func<Client, bool > predicate) 
        {
            var result = _vIClientRepository.GetAll(predicate);
            return result;
        }

        public IQueryable<Client> GetAllActive (Situations pSituations)
        {
            var result = _vIClientRepository.GetAllActive(pSituations);
            return result;
        }

        public Task<IEnumerable<Client>> GetAllAsync(Expression<Func<Client, bool>> predicate) 
        {
            var result = _vIClientRepository.GetAllAsync(predicate);
            return result;
            
        }

        public async Task<Client> GetById(long Id)
        {
            var result = await _vIClientRepository.GetById(Id);
            return result;
        }

        public async Task<Client> Update(Client entity)
        {
            var result = await _vIClientRepository.Update(entity);
            return result;  
        }

        public async Task UpdateRange(IEnumerable<Client> entity)
        {
             await _vIClientRepository.UpdateRange(entity);
        }
    }
}