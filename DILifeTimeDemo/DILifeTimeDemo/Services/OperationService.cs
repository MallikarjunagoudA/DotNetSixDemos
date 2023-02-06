using DILifeTimeDemo.Interfaces;

namespace DILifeTimeDemo.Services;


public class OperationService : IOperation, ISingletonOperation, IScopedOperation, ITrasitiveOperation
{
    private Guid _operationid;

    // 1.   Parameterized constructor will call second. the default constructor will call this by passing the new guid.
    public OperationService(Guid operationid)
    {
        _operationid = operationid;
    }

    // 2.    Default constructor will call first. that will call the parameterized constructor with a guid.
    public OperationService() : this(Guid.NewGuid())
    {

    }

    // 3.    Will return this operationid.
    public Guid Operationid 
    {
        get
        {
            return _operationid;
        }

        set
        {
            _operationid = value;
        }
    }
}
