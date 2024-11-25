// For more information see https://aka.ms/fsharp-console-apps
type Currency = {symbol: string}
type Amount = {currency: Currency; value: decimal}

let price = {currency={symbol="USD"}; value=20M}

type Product = {name: string; unitPrice: Amount}

let steeringWheel = {name="Steering Wheel"; unitPrice=price}

let scale factor amount = {currency = amount.currency; value = amount.value * factor}
let add amount value = {currency = amount.currency; value = amount.value + value}

let basePrice product quantity = scale (decimal quantity) product.unitPrice
let flatTax (product: Product) amount = scale 0.2M amount

type PriceSpecification = {basePrice: Amount; tax: Amount}

let priceSpecification (tax: Product -> Amount -> Amount) product quantity =
    let basePrice = basePrice product quantity
    {basePrice=basePrice; tax=(tax product basePrice)}
    
let totalPriceCalculator (tax: Product -> Amount -> Amount) product quantity =
    let spec = priceSpecification tax product quantity
    (quantity, add spec.basePrice spec.tax.value)

let priceTable = totalPriceCalculator flatTax

printfn "Hello from F#";;
printfn "The price of 2x %s is %A" steeringWheel.name (priceTable steeringWheel 2)