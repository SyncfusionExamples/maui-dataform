namespace ManualValidation
{
    internal class ValidationViewModel
    {
        public ValidationViewModel()
        {
            this.ManualValidationModel = new ValidationModel();
        }

        public ValidationModel ManualValidationModel { get; set; }
    }
}
