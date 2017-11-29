/**
 * Carledger transaction processor function.
 * @param {org.codeart.carledger.MileageTransaction} tx The sample transaction instance.
 * @transaction
 */
function mileageTransaction(tx) {

    // Save the old value of the asset.
    var oldMileage = tx.asset.mileage;

    // Update the asset with the new value.
    tx.asset.mileage = tx.newMileage;

    // Get the asset registry for the asset.
    return getAssetRegistry('org.codeart.carledger.Car')
        .then(function (carRegistry) {

            // Update the asset in the asset registry.
            return carRegistry.update(tx.asset);

        })
        .then(function () {

            // Emit an event for the modified asset.
            var event = getFactory().newEvent('org.codeart.carledger', 'MileageEvent');
            event.asset = tx.asset;
            event.oldMileage = oldMileage;
            event.newMileage = tx.newMileage;
            emit(event);

        });

}
