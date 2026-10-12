using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace Service
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;

        #region [- ctor -]
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        }
        #endregion

        #region [- GetAllPerson() -]
        public List<GetPersonDto> GetAllPerson()
        {
            var people = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in people)
            {
                var getPersonDto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(getPersonDto);
            }
            return getPersonDtos;
        }
        #endregion

        #region [- Post() -]
        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName,
            };
            _personServiceModel.Insert(person);
        }
        #endregion

        #region [- Update() -]
        public void Update(UpdatePersonDto updatePersonDto)
        {
            var person = new Person()
            {
                Id = updatePersonDto.Id,
                FirstName = updatePersonDto.FirstName,
                LastName = updatePersonDto.LastName,
            };
            _personServiceModel.Update(person);
        }
        #endregion

        #region [- Delete() -]
        public void Delete(DeletePersonDto deletePersonDto)
        {
            var person = new Person()
            {
                Id = deletePersonDto.Id,
            };
            _personServiceModel.Delete(person);
        }
        #endregion
    }
}
