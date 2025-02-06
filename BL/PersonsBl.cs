using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class PersonsBl:IPersonsBl
    {
        IMapper _mapper;
        IPersonsDl _IPersonsDl;
        public PersonsBl(IMapper mapper, IPersonsDl iPersonsDl)
        {
            _mapper = mapper;
            _IPersonsDl = iPersonsDl;
        }
        public async Task<PersonsDTO> add(PersonsDTO personsDTO)
        {
            Persons persons = _mapper.Map<Persons>(personsDTO);
            Persons personsAfterAdd = await _IPersonsDl.add(persons);
            PersonsDTO personsDTOToReturn = _mapper.Map<PersonsDTO>(personsAfterAdd);
            return personsDTOToReturn;
        }

        public async Task<PersonsDTO> delete(int idPersonsDTO)
        {
            Persons personsAfterDelete = await _IPersonsDl.delete(idPersonsDTO);
            PersonsDTO personsDTOToReturn = _mapper.Map<PersonsDTO>(personsAfterDelete);
            return personsDTOToReturn;
        }

        public async Task<PersonsDTO> edit(PersonsDTO personsDTO)
        {
            Persons persons = _mapper.Map<Persons>(personsDTO);
            Persons personsAfterEdit = await _IPersonsDl.edit(persons);
            PersonsDTO personsDTOToReturn = _mapper.Map<PersonsDTO>(personsAfterEdit);
            return personsDTOToReturn;
        }

        public async Task<List<PersonsDTO>> getAll()
        {
            List<Persons> allPersons = await _IPersonsDl.getAll();
            List<PersonsDTO> allPersonsDTOToReturn = _mapper.Map<List<Persons>, List<PersonsDTO>>(allPersons);
            return allPersonsDTOToReturn;
        }

        public async Task<PersonsDTO> getById(int idPersonsDTO)
        {
            Persons persons = await _IPersonsDl.getById(idPersonsDTO);
            PersonsDTO personsDTOToReturn = _mapper.Map<PersonsDTO>(persons);
            return personsDTOToReturn;
        }
    }
}