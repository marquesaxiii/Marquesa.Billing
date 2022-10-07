using Identity.Domain.DataTransferObjects;

namespace Identity.Core.Interface;

public interface IDataLayer
{
    public MarquesaSystemContext MarquesaSystemContext { get; set; }
}