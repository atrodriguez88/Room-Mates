using System.Linq;
using AutoMapper;
using Room_Mates.Controllers.Resources;
using Room_Mates.Core.Models;

namespace Room_Mates.Mapping
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // Domain to API (GET)
            CreateMap<RoomFeatures,RoomFeaturesResource>();            
            CreateMap<Ocupation,OcupationResource>();            
            CreateMap<PropertyFeatures,PropertyFeaturesResource>();            
            CreateMap<PropertyRules,PropertyRulesResource>();            
            CreateMap<Core.Models.Profile, ProfileResource>();
            CreateMap<Room, RoomResource>();
            // .ForMember(rr => rr.Rules, opt => opt.MapFrom(r => r.Rules.Select(rr => new PropertyRulesResource{Id = rr.Id, Name = rr.Name})));

            //API to Domain (POST, PUT)
            CreateMap<RoomFeaturesResource, RoomFeatures>()          
            .ForMember(r => r.Id, opt => opt.Ignore());            
            CreateMap<OcupationResource, Ocupation>()          
            .ForMember(o => o.Id, opt => opt.Ignore());            
            CreateMap<PropertyFeaturesResource, PropertyFeatures>()          
            .ForMember(p => p.Id, opt => opt.Ignore());            
            CreateMap<PropertyRulesResource, PropertyRules>()
            .ForMember(p => p.Id, opt => opt.Ignore());
            CreateMap<ProfileResource, Core.Models.Profile>()
            .ForMember(p => p.Id, opt => opt.Ignore());
            CreateMap<RoomResource, Room>()
            .ForMember(p => p.Id, opt => opt.Ignore());
            // .ForMember(r => r.Rules, opt => opt.MapFrom(rr => rr.Rules.Select(id => new PropertyRules{Id = id})));
            
            // .ForMember(r => r.Rules, opt => opt.Ignore())
            // .AfterMap((r, rr) =>
            // {

            // });

        }
    }
}