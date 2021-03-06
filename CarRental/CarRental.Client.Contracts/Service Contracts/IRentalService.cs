using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using CarRental.Client.Entities;
using CarRental.Common;
using Core.Common.Contracts;
using Core.Common.Exceptions;

namespace CarRental.Client.Contracts
{
    [ServiceContract]
    public interface IRentalService : IServiceContract
    {
        [OperationContract(Name = "RentCarToCustomerImmediately")]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(CarCurrentlyRentedException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Rental RentCarToCustomer(string loginEmail, int carId, DateTime dateDueBack);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(CarCurrentlyRentedException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Rental RentCarToCustomer(string loginEmail, int carId, DateTime rentalDate, DateTime dateDueBack);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void AcceptCarReturn(int carId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        IEnumerable<Rental> GetRentalHistory(string loginEmail);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Reservation GetReservation(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Reservation MakeReservation(string loginEmail, int carId, DateTime rentalDate, DateTime returnDate);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void ExecuteRentalFromReservation(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void CancelReservation(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        CustomerReservationData[] GetCurrentReservations();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        CustomerReservationData[] GetCustomerReservations(string loginEmail);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Rental GetRental(int rentalId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        CustomerRentalData[] GetCurrentRentals();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Reservation[] GetDeadReservations();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        bool IsCarCurrentlyRented(int carId);

        #region Async operations

        [OperationContract(Name = "RentCarToCustomerImmediatelyAsync")]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(CarCurrentlyRentedException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<Rental> RentCarToCustomerAsync(string loginEmail, int carId, DateTime dateDueBack);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(CarCurrentlyRentedException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<Rental> RentCarToCustomerAsync(string loginEmail, int carId, DateTime rentalDate, DateTime dateDueBack);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Task AcceptCarReturnAsync(int carId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<IEnumerable<Rental>> GetRentalHistoryAsync(string loginEmail);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<Reservation> GetReservationAsync(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Task<Reservation> MakeReservationAsync(string loginEmail, int carId, DateTime rentalDate, DateTime returnDate);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Task ExecuteRentalFromReservationAsync(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Task CancelReservationAsync(int reservationId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<CustomerReservationData[]> GetCurrentReservationsAsync();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<CustomerReservationData[]> GetCustomerReservationsAsync(string loginEmail);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<Rental> GetRentalAsync(int rentalId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<CustomerRentalData[]> GetCurrentRentalsAsync();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<Reservation[]> GetDeadReservationsAsync();

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        [FaultContract(typeof(AuthorizationValidationException))]
        Task<bool> IsCarCurrentlyRentedAsync(int carId);

        #endregion
    }
}
